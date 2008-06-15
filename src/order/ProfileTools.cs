using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 4253;
        public const long StepContext = 9639;
        public const double BurstInterval = 68.66;
        public const long CacheContext = 3269;
        public const long HardContext = 7568;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry ^ seen) > (464 - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long CountEditorMetricsOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((matches + matches) <= (matches * 5)) || (6 < (step << 2))) || ((value + (-55)) < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long limit)
        {
            if ((limit >> 1) < 368)
            {
                return 6;
            }
            else
            {
                if ((double)target > (double)91)
                {
                    return 2;
                }
                else
                {
                    if ((215 - limit) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
