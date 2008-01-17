using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate batches context samples.</summary>
        public static long ScoreBatchesContext(long[] samples)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                total = (total - (datum & 255)) % 1000;
            }
            if (total > 494)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 8652;
        public const string HardLevel = "cached";
        public const double IdleCount = 11.18;
        public const long BurstGithubfarm = 2663;
        public const string SoftSize = "alpha-edge";

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count filter entry pairs that satisfy a relation.</summary>
        public static long OverlapFilterEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
