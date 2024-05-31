﻿using System;
using System.Collections.Generic;
using Sandbox.ModAPI;
using SC.SUGMA.HeartNetworking.Custom;
using VRage.Game.ModAPI;

namespace SC.SUGMA.GameState
{
    internal class PointTracker : ComponentBase
    {
        public int VictoryPoints = 3;
        public int StartingPoints;

        public Dictionary<IMyFaction, int> FactionPoints { get; internal set; } = new Dictionary<IMyFaction, int>();

        #region Base Methods

        public PointTracker(int startingPoints, int victoryPoints)
        {
            StartingPoints = startingPoints;
            VictoryPoints = victoryPoints;
        }

        public override void Init(string id)
        {
            base.Init(id);
            MyAPIGateway.Session.Factions.FactionCreated += OnFactionCreated;
            foreach (var faction in MyAPIGateway.Session.Factions.Factions)
                OnFactionCreated(faction.Key);
        }

        public override void Close()
        {
            
        }

        public override void UpdateTick()
        {
            foreach (var faction in FactionPoints)
            {
                //MyAPIGateway.Utilities.ShowNotification($"{faction.Key.Tag}: {faction.Value}", 1000/60);
            }
        }

        #endregion

        #region Public Methods

        public Action<IMyFaction> OnFactionWin;

        public int GetFactionPoints(IMyFaction faction)
        {
            return FactionPoints.GetValueOrDefault(faction, int.MinValue);
        }

        public int GetFactionPoints(long factionId)
        {
            return GetFactionPoints(MyAPIGateway.Session.Factions.TryGetFactionById(factionId));
        }

        public void SetFactionPoints(IMyFaction faction, int value)
        {
            if (!FactionPoints.ContainsKey(faction))
                return;

            FactionPoints[faction] = value;

            if (VictoryPoints > StartingPoints ? value >= VictoryPoints : value <= VictoryPoints)
                OnFactionWin?.Invoke(faction);
        }

        public void SetFactionPoints(long factionId, int value)
        {
            SetFactionPoints(MyAPIGateway.Session.Factions.TryGetFactionById(factionId), value);
        }

        public void AddFactionPoints(IMyFaction faction, int value)
        {
            if (!FactionPoints.ContainsKey(faction))
                return;

            FactionPoints[faction] += value;

            if (VictoryPoints > StartingPoints ? FactionPoints[faction] >= VictoryPoints : FactionPoints[faction] <= VictoryPoints)
                OnFactionWin?.Invoke(faction);
        }

        public void AddFactionPoints(long factionId, int value)
        {
            AddFactionPoints(MyAPIGateway.Session.Factions.TryGetFactionById(factionId), value);
        }

        public void UpdateFromPacket(PointsPacket packet)
        {
            FactionPoints = packet.FactionPoints;
        }

        #endregion

        private void OnFactionCreated(long factionId)
        {
            FactionPoints.Add(MyAPIGateway.Session.Factions.TryGetFactionById(factionId), StartingPoints);
        }
    }
}
