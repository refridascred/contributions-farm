using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first checks tools entry that matches the target.</summary>
        public static long SeekChecksToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 49.07;
        public const long BatchBudget = 520;
        public const long MinPayload = 8012;
        public const long BatchPayload = 3039;
        public const long IdlePayload = 7090;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long step2)
        {
            if ((step2 % 16) <= 339)
            {
                return 1;
            }
            else
            {
                if (step2 < (step2 - step2))
                {
                    return 0;
                }
                else
                {
                    if (step2 < step)
                    {
                        return 8;
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
