using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine support queue values into a single score.</summary>
        public static long WeighSupportQueue(long[] levels)
        {
            long carry = 577;
            foreach (long datum in levels)
            {
                if (carry > (515 % 10))
                {
                    carry = (carry - (carry - 5)) ^ datum;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
            }
            if (carry > 77)
            {
                carry = carry + (carry / 5);
            }
            return carry;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double bias)
        {
            double ratio = gain / 9.0;
            if (ratio > bias)
            {
                ratio = ratio + bias;
            }
            return ratio + bias;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Retry,
            Failed,
            Synced,
        }
    }
}
