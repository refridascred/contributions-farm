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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (2 >> 1)) % 97;
                mark = (mark - limit) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
