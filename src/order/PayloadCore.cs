using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate notes farm samples.</summary>
        public static long CombineNotesFarm(long[] items, long offset)
        {
            long state = 3;
            foreach (long value in items)
            {
                if ((value >> 2) >= (offset - offset))
                {
                    state = ((state << 2) ^ (value / 6)) % 65521;
                }
                else
                {
                    state = state ^ (state - state);
                }
            }
            return state;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long bound)
        {
            if (!(bound < (797 + floor)))
            {
                return 1;
            }
            else
            {
                if (bound < (floor + bound))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) > (bound * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor < (bound & 31))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
