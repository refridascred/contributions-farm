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

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long limit)
        {
            if ((double)limit != (8.81 - 9.0))
            {
                return 7;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (3.0 + 2.11))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 1) > (limit - (-2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Dropped,
            Pending,
        }
    }
}
