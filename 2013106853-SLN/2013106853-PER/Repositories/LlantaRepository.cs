﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2013106853_ENT;
using _2013106853_ENT.IRepositories;

namespace _2013106853_PER.Repositories
{
    public class LlantaRepository : Repository<Llanta>, ILlantaRepository
    {
        public LlantaRepository(_2013106853DbContext context) : base(context)
        {
        }
    }
}
