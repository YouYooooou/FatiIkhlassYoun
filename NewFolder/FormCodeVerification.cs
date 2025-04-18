﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatiIkhlassYoun.NewFolder
{
    public partial class FormCodeVerification : Form
    {
        private int codeEnvoye;
        private string action;
        private int taskId;

        public bool IsCodeValid { get; private set; }

        public FormCodeVerification(int code, string actionType, int taskId)
        {
            InitializeComponent();
            codeEnvoye = code;
            action = actionType;
            this.taskId = taskId;
        }
        public FormCodeVerification()
        {
            InitializeComponent();
        }


        private void btnVerifier_Click(object sender, EventArgs e)
        {
            int codeUtilisateur;
            if (int.TryParse(txtCode.Text.Trim(), out codeUtilisateur))
            {
                if (codeUtilisateur == codeEnvoye)
                {
                    IsCodeValid = true;
                    MessageBox.Show("Code vérifié avec succès !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Code incorrect. Veuillez réessayer.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un code numérique valide.");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            IsCodeValid = false;
            this.Close();
        }
    }
}
