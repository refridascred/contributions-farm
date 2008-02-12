using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double offset)
        {
            double mean = (double)(3 / 2);
            if (mean >= (rate / 3.0))
            {
                mean = mean + 7.09;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (1.0 + rate)) - (double)(long)i;
            }
            return mean + (rate / 5.0);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((carry - (long)i) >= (carry % 64))
                {
                    carry = (carry ^ (bound ^ bound)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
