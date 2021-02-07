﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.EntityFramework.Services
{
    public interface IService<T>
    {
        public Task<T> Get(int id);
        public Task<IEnumerable<T>> GetAll();
    }
}