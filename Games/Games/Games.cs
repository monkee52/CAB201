using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace Games {
    public enum Games {
        [Description("Two Up")]
        TwoUp,
        [Description("Snake Eyes")]
        SnakeEyes,
        [Description("Captain Ship Crew")]
        CaptainShipCrew,
        [Description("Twenty One")]
        TwentyOne,
        [Description("Crazy Eights")]
        CrazyEights
    };

    /// <summary>
    /// Small utility methods to assist in bootstrapping games
    /// </summary>
    static class GamesImplementation {
        /// <summary>
        /// Turn an enum value into a user-friendly string
        /// </summary>
        /// <param name="game">Which game</param>
        /// <returns>The user friendly name</returns>
        public static string GetGameName(Games game) {
            FieldInfo field = game.GetType().GetField(game.ToString());
            DescriptionAttribute[] attribs = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            // Return original value if no user-friendly option exists
            return attribs.Length > 0 ? attribs[0].Description : game.ToString();
        }

        /// <summary>
        /// Opens a form for the user to play a game
        /// </summary>
        /// <param name="game">Which game</param>
        public static void PlayGame(Games game) {
            Form form = null;

            switch (game) {
                case Games.TwoUp:
                    form = new FormGameTwoUp();
                    break;
                case Games.SnakeEyes:
                    form = new FormGameSnakeEyes();
                    break;
                case Games.TwentyOne:
                    form = new FormGameTwentyOne();
                    break;
                case Games.CrazyEights:
                    form = new FormGameCrazyEights();
                    break;
                default:
                    MessageBox.Show("Game '" + game.ToString() + "' has not been implemented yet.");
                    break;
            }

            if (form != null) {
                form.ShowDialog();
            }
        }
    }
}
