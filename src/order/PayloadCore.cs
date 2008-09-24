using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a metrics window counter forward.</summary>
        public static long StepMetricsWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 3) ^ 862) % 101;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double weight = (double)((-94) / 5);
            if (weight <= (double)48)
            {
                weight = weight - (19.0 + offset);
            }
            else
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (offset / 8.0)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool GuardRouteStatsLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
