using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial1.Entidades;


public static class ClsUsuario
    {
        public static bool Acceso(Usuario usuario)
        {
            return usuario.Nombre == "TU_NOMBRE" && usuario.Contraseña == "123";
        }
    }