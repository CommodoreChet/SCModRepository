﻿using RichHudFramework;
using RichHudFramework.UI;
using RichHudFramework.UI.Client;
using RichHudFramework.UI.Rendering;
using VRageMath;

namespace SC.SUGMA.GameState
{
    internal class ProblemReport : ComponentBase
    {
        private Label _labelTop = new Label
        {
            Format = new GlyphFormat(Color.Red, TextAlignment.Center, 2.5f),
            ParentAlignment = ParentAlignments.Top,
            Text = "A PROBLEM HAS BEEN REPORTED.",
        };
        private Label _labelMiddle = new Label(HudMain.HighDpiRoot)
        {
            Format = new GlyphFormat(Color.White, TextAlignment.Center, 1.75f),
            Text = "CHECK WITH BOTH TEAMS, THEN TYPE '/sc fixed' TO CLEAR THIS MESSAGE.",
        };
        private Label _labelBottom = new Label
        {
            Format = new GlyphFormat(Color.Yellow, TextAlignment.Center, 1.75f),
            ParentAlignment = ParentAlignments.Bottom,
        };

        public ProblemReport(string message)
        {
            _labelBottom.Text = $"{message}";

            _labelMiddle.RegisterChild(_labelTop);
            _labelMiddle.RegisterChild(_labelBottom);
        }

        public override void Close()
        {
            _labelMiddle.Parent.RemoveChild(_labelMiddle);
        }

        public override void UpdateTick()
        {
            
        }
    }
}
