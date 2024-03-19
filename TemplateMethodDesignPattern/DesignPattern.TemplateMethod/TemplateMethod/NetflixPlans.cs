using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            PersonCount(0);
            Price(0);
            Resolution(string.Empty);
            Content(string.Empty);
        }

        public abstract string PlanType(string planType);
        public abstract int PersonCount(int personCount);
        public abstract double Price(double price);
        public abstract string Resolution(string resolution);
        public abstract string Content(string content);
    }
}
