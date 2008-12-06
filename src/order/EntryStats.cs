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

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long limit)
        {
            long slot = bound - limit;
            if (!((limit ^ bound) == (slot % 100)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (bound > (limit - slot))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((slot >> 1) == (limit / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7899;
        public const string MinAccount = "alpha-edge";
        public const long DefaultAccount = 1548;
        public const string StepScore = "latest";
        public const long HardScore = 4239;
    }
}
