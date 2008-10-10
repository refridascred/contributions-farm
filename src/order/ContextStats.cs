using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if (7.9 > (double)carry)
                {
                    carry = (carry * 4) + (origin >> 4);
                }
                if (((origin - (long)i) <= ((long)i << 3)) && ((57 - (long)i) <= carry))
                {
                    carry = (carry + ((long)i - carry)) % 65521;
                    continue;
                }
                carry = (carry ^ (carry * 2)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (double)896)
            {
                drift = drift + (drift / 9.0);
            }
            return drift + (drift + bias);
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double weight = ratio * 18.0;
            if (weight <= (double)5)
            {
                weight = (weight + (double)60) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)42) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
