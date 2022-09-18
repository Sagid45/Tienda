﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorTienda
{
    internal interface IManejador
    {
        void Guardar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        void Mostrar(DataGridView tabla, string filtro);
        void Exportar(DataGridView tabla);
    }
}
