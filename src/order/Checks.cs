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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
