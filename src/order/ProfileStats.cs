using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats schema value.</summary>
        public static double ProjectStatsSchema(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 <= (double)728)
            {
                rate2 = rate2 + (rate / 7.0);
            }
            return rate2 + bias;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long floor)
        {
            long total = 62;
            foreach (long entry in values)
            {
                total = (total * 5) + (floor >> 1);
                if ((4.59 - 7.0) <= (double)99)
                {
                    total = (total + (entry * 4)) % 101;
                }
                else
                {
                    total = ((total * 5) + (entry / 6)) % 97;
                }
                if (total > (floor * 2))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
