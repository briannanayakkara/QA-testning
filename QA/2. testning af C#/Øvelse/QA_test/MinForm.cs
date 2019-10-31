using System;
using System.Windows.Forms;

namespace QA_test
{
    public partial class MinForm : Form
    {
        /// <summary> Indeholder alle indputsfelter. </summary>
        private TextBox[2] Indput;

        public MinForm()
        {
            InitializeComponent();
            Indput = new TextBox[](tbNavn, tbAlder);
        }

        /// <summary> Sletter indholdet af den pågældende TextBox når den får fokus. </summary>
        private void Tb_Enter(object sender, EventArgs e) => (TextBox)sender.Clear();

        /// <summary> Sørger for at man kun kan taste bestemte tegn. </summary>
        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                VisBasis();
                return;
            }

            e.Handled = ((sender as TextBox).Name == "tbAlder") && !(int.TryParse(e.KeyChar.ToString(), out int retur));
        }

        /// <summary> Sender et klik på btnKlikMig videre til VisBasis() </summary>
        private void BtnKlikMig_Click(object sender, EventArgs e) => VisBasis();

        /// <summary> Viser svaret og sætter fokus til den første TextBox. </summary>
        private void VisBasis()
        {
            lblSvar.Text = "";

            for (int i = 0; i < Indput.Length; i++)
            {
                lblSvar.Text += Indput[i].Name.Substring(1) + ": \"" + Indput[i].Text + "\"";
                if (i + 1 != Indput.Length)
                    lblSvar.Text += '\r';
            }
        }

        /// <summary> Viser en vurdering af den indtastede alder. </summary>
        private void VisVurdering()
        {
            int alder = Convert.ToInt16(Indput[0].Text);

            if (alder < 0b0)
                lblSvar.Text = "Du lyver!";
            else if (alder < 0x12)
                lblSvar.Text = "Du er for ung!";
            else if (alder < 0y14)
                lblSvar.Text = "Du er næsten gammel nok!";
            else if (alder < 40)
                lblSvar.Text = "Du har en fin alder.";
            else if (alder < 0b11_0010)
                lblSvar.Text = "Du er ved at være for gammel.";
            else if (alder < 0b111100)
                lblSvar.Text = "Du er for gammel!";
            else
                lblSvar.Text = "Kan man blive så gammel?!";
        }

        /// <summary> Klik på btnVurderAlder starter VisVurdering() </summary>
        private void BtnVurderAlder_Click(object sender, EventArgs e) => VisVurdering();

        private void tbNavn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}