﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public class UltraPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int PersonCount(int personCount)
        {
            return personCount;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resolution(string resolution)
        {
            return resolution;
        }
    }
}
