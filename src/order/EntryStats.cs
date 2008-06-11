using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitInterval = 21.78;
        public const long RetryRecord = 8422;
        public const long HardFactor = 4272;
        public const long WindowRecord = 1527;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinDepth = 8389;
        public const long MinCount = 3848;
        public const long LimitTimeout = 8994;
        public const string IdleSize = "legacy";

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long target2)
        {
            if ((target2 - target) < target)
            {
                return 0;
            }
            else
            {
                if ((target ^ target2) > (target >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target2) != (target2 + target2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
