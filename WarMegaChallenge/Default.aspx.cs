using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WarMegaChallenge
{
/// <summary>
/// The results of the deal (Which cards were dealt to which player)
///The beginning of the Battle phase
///For each battle, which cards are being compared
///The bounty of cards (Which cards are at stake to be claimed)
///The winner of each battle
///Signal when a war condition is reached
///Which player won the game, and how many cards each player is left with
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            Game game = new Game("Player1", "Player2");
            resultLabel.Text = game.Play();
        }
    }
}