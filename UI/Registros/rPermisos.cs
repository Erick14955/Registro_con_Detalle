﻿using Registro_con_Detalle.BLL;
using Registro_con_Detalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_con_Detalle
{
    public partial class rPermisos : Form
    {
        public rPermisos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
        }

        private void LlenarCampos(Permisos permiso)
        {
            IDnumericUpDown.Value = permiso.PermisosId;
            DescripciontextBox.Text = permiso.DescripcionPermisos;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            ErroreserrorProvider.Clear();
            int id;
            Permisos permiso = new Permisos();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            permiso = PermisosBLL.Buscar(id);

            if(permiso != null)
            {
                LlenarCampos(permiso);
            }
            else
            {
                MessageBox.Show("El permiso no ha sido encontrada o no esta registrada");
            }
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Permisos permiso = PermisosBLL.Buscar((int)IDnumericUpDown.Value);

            return (permiso != null);
        }
    }
}
