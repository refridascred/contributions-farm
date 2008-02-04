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

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 1706;
        public const double MaxQueue = 13.32;
        public const string BaseQueue = "strict-v2";
        public const long IdleQueue = 476;
        public const long LimitQueue = 9025;

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchRatio = 1504;
        public const string HardInterval = "local-edge";
        public const long CacheInterval = 4009;
    }
}
