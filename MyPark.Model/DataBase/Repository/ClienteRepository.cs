﻿using MyPark.Model.DataBase.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPark.Model.DataBase.Repository
{
    public class ClienteRepository : RepositoryBase<cliente>
    {
        public ClienteRepository(ISession session) : base(session) { }

    }
}
