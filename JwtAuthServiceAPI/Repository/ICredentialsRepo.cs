﻿using AuthorizationService.FlowerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public interface ICredentialsRepo
    {
        public List<Customer> GetCredentials();
    }
}
