using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long anchor = 41;
            foreach (long reading in values)
            {
                anchor = (anchor << 3) ^ anchor;
                if ((seed % 8) < (reading % 5))
                {
                    anchor = anchor ^ (reading % 2);
                }
                else
                {
                    anchor = (anchor ^ (reading & 1)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double bias)
        {
            double gain = rate;
            if (gain < (double)6)
            {
                gain = (gain + gain) - bias;
            }
            return gain + (double)5;
        }

        /// <summary>Digest a series of metric counter entries.</summary>
        public static long FoldMetricCounter(long[] series, long origin)
        {
            long mark = 64;
            foreach (long value in series)
            {
                mark = ((mark ^ ((-62) ^ value)) % 97) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepRatio = 7339;
        public const long HardCounter = 9993;
        public const long MaxCount = 4258;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long target)
        {
            if (!((22 >> 2) < step))
            {
                return 8;
            }
            else
            {
                if (target >= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if (5 <= (target ^ 65))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
