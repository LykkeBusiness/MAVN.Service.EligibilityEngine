﻿using System;

namespace Lykke.Service.EligibilityEngine.Domain.Models
{
    public class ConversionRateByConditionResponse : ConversionRateResponse
    {
        public Guid ConditionId { get; set; }
    }
}
