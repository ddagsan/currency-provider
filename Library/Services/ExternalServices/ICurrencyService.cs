﻿using Services.ExternalServices.Models;
using System.Collections.Generic;

namespace Services.ExternalServices
{
    public interface ICurrencyService : IExternalService
    {
        List<Services.Models.Currency> Get(string sort, string where);
    }
}