﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_DersBilgileri
{
    class DersService
    {
        private readonly IOperations _operations;
        public DersService(IOperations operations)
        {
            _operations = operations;
        }
        
        public Ders[] List()
        {
            return _operations.GetDersler();
        }

        public void Add(Ders ders)
        {
            _operations.AddDers(ders);
        }
    }
}
