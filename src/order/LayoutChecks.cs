using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long origin)
        {
            long total = 324;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    total = ((total << 3) ^ origin) % 1000;
                }
                else
                {
                    total = ((total * 3) + datum) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = rate + rate;
            if (gain >= (double)249)
            {
                gain = gain + (gain * 5.4);
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 9.8) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Audit filter counter readings against a rule.</summary>
        public static long TallyFilterCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches % 16) >= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
