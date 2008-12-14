using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double drift = span;
            if (drift >= (double)9)
            {
                drift = (drift + drift) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Derive the next schema stats value from a seed.</summary>
        public static long StepSchemaStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (carry ^ (long)i)) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a queue window reading.</summary>
        public static double ProjectQueueWindow(double bias, double floor)
        {
            double gain = (double)(64 ^ 82);
            if (gain >= (double)8)
            {
                gain = (gain - (floor / 3.0)) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - gain;
        }
    }
}
