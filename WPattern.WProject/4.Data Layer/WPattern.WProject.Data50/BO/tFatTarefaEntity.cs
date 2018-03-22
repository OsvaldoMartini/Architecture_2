﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPattern.WProject.Data50.Utils;

namespace WPattern.WProject.Data50
{
    partial class tFatTarefaEntity : BaseBO
    {
        public override void Validation()
        {
            if (USUARIO_ULTIMA_ALTERACAO.Length <= 10)
            {
                throw new Exception("USUARIO_ULTIMA_ALTERACAO deve ser maior que 10!");
            }
        }
    }
}
