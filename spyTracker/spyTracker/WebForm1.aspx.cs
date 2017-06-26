using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace spyTracker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetName = new string[0];
                ViewState.Add("Name", assetName);

                int[] electionRigged = new int[0];
                ViewState.Add("elections", electionRigged);

                int[] actsSubterfuge = new int[0];
                ViewState.Add("subterfuge", actsSubterfuge);
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string[] assetName = (string[])ViewState["Name"];
            Array.Resize(ref assetName, assetName.Length + 1);
            int newestName = assetName.GetUpperBound(0);
            assetName[newestName] = assetTextBox.Text;
            ViewState["Name"] = assetName;


            int[] electionRigged = (int[])ViewState["elections"];
            Array.Resize(ref electionRigged, electionRigged.Length + 1);
            int newElection = electionRigged.GetUpperBound(0);
            electionRigged[newElection] = int.Parse(electionsTextBox.Text);
            ViewState["elections"] = electionRigged;

            int[] actsSubterfuge = (int[])ViewState["subterfuge"];
            Array.Resize(ref actsSubterfuge, actsSubterfuge.Length + 1);
            int newSubterfuge = actsSubterfuge.GetUpperBound(0);
            actsSubterfuge[newSubterfuge] = int.Parse(subterfugeTextBox.Text);
            ViewState["subterfuge"] = actsSubterfuge;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}</br>Average acts of Subterfuge per asset:{1:N1}</br> (Last Asset you Added: {2})",
                electionRigged.Sum(),
                actsSubterfuge.Average(),
                assetName[newestName]);
        }
    }
}