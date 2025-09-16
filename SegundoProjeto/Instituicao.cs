﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Instituicao
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Departamento[] Departamentos { get; } = new Departamento[5];

        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
        {
            if (quantidadeDepartamentos < 10)
                Departamentos[quantidadeDepartamentos++] = d;
        }

        public int ObterQuantidadeDepartamentos()
        {
            return quantidadeDepartamentos;
        }
    }

}
