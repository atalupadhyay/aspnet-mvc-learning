﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelCard.DomainModel.Entities;

namespace TravelCard.DomainModel.Abstract
{
    public interface IFrequencyRepository
    {

        IQueryable<Frequency> Frequency { get; }

        void Update(Frequency frequency_);
        int Insert(Frequency frequency_);

    }
}
