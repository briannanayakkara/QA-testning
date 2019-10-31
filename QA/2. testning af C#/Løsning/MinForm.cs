using System;
using System.Windows.Forms;

namespace QA_test {
    public partial class MinForm : Form {
        /// <summary> Indeholder alle indputsfelter. </summary>
        private TextBox[] Indput; //FIXME der skal ikke stå noget tal

        public MinForm() {
            InitializeComponent();
            Indput = new TextBox[] { tbNavn, tbAlder }; //FIXME der var brugt () i stedet for {}
        }

        /// <summary> Sletter indholdet af den pågældende TextBox når den får fokus. </summary>
        private void Tb_Enter(object sender, EventArgs e) => ((TextBox)sender).Clear(); //FIXME der manglede () rundt om typecast

        /// <summary> Sørger for at man kun kan taste bestemte tegn. </summary>
        private void Tb_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                VisBasis();
                return;
            }

            e.Handled = ((sender as TextBox).Name == "tbAlder") && !(int.TryParse(e.KeyChar.ToString(), out int retur)); //FIXME && var ||
        }

        /// <summary> Sender et klik på btnKlikMig videre til VisBasis() </summary>
        private void BtnKlikMig_Click(object sender, EventArgs e) => VisBasis();

        /// <summary> Viser svaret og sætter fokus til den første TextBox. </summary>
        private void VisBasis() {
            lblSvar.Text = "";

            for (int i = 0; i < Indput.Length; i++) {
                lblSvar.Text += Indput[i].Name.Substring(2) + ": \"" + Indput[i].Text + "\""; //FIXME Substring(2) i stedet for 1
                if (i + 1 != Indput.Length) 
                    lblSvar.Text += '\r';
            }
        }

        /// <summary> Klik på btnVurderAlder starter VisVurdering() </summary>
        private void BtnVurderAlder_Click(object sender, EventArgs e) => VisVurdering();

        /// <summary> Viser en vurdering af den indtastede alder. </summary>
        private void VisVurdering() {
            int alder = Convert.ToInt16(Indput[1].Text); //FIXME Indput[0] i stedet for Indput[1] eller tbAlder

            if (alder < 0b0)
                lblSvar.Text = "Du lyver!";
            else if (alder < 0x12)
                lblSvar.Text = "Du er for ung!";
            else if (alder < 0x14) //FIXME x var et y
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
    }
}