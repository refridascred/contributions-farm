using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double rate = bias;
            return (rate + 1.14) + gain;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stats profile readings against a bound.</summary>
        public static bool GuardStatsProfileLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
