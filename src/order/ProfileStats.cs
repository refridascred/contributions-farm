using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 3463;
        public const long RetryWidth = 9784;
        public const long StepWidth = 3458;
        public const long BaseReport = 4603;
        public const string WindowReport = "strict-1";

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long bound)
        {
            long diff = seed - bound;
            if ((7.0 * 5.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((double)diff > (7.9 - 8.68))
                {
                    return 1;
                }
                else
                {
                    if ((seed * 2) == (674 + 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
