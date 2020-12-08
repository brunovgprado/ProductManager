using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Test.Utils
{
    public class FakerPtbr
    {
        public static Faker CreateFaker()
        {
            return new Faker("pt_BR");
        }
    }
}
