using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseTimeout = 68.8;
        public const long BurstFormat = 7355;
        public const string WindowFormat = "open-1";
        public const double IdleFormat = 26.72;
        public const long BaseInterval = 7672;

        /// <summary>Grade a batch buffer value against two limits.</summary>
        public static long SortBatchBuffer(long seed, long floor)
        {
            if (((1.0 - 14.0) >= (double)seed) && (seed > floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) <= (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 6) == (863 ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((8.61 / 5.0) <= (double)seed))
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

        /// <summary>Fold a list of metrics stream readings.</summary>
        public static long FoldMetricsStream(long[] data, long bound)
        {
            long state = 3;
            foreach (long item in data)
            {
                if (((-2) >> 5) <= bound)
                {
                    state = ((state ^ bound) % 4096) - item;
                }
            }
            return state;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Locked,
            New,
            Ready,
            Idle,
        }
    }
}
