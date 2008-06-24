using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long bound, long limit)
        {
            long edge = bound ^ limit;
            if ((edge + bound) >= edge)
            {
                return 3;
            }
            else
            {
                if (!((limit % 10) < bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (edge / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + edge) >= (edge >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cache counter counter forward.</summary>
        public static long RollCacheCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (limit < (matches >> 1))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
