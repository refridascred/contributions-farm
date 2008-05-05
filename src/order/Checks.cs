using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = 59;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = mix - ((long)i * 5);
                }
                if (value > mix)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!!(item > (329 + 8)))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
