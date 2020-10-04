﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            // Chama o método da classe base (Funcionario)
            return Salario + base.GetBonificacao();
        }
        public Diretor() { }
    }
}
