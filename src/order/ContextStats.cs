using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot ^ offset) < ((-946) % 7))
            {
                return 0;
            }
            else
            {
                if (bound > offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Active,
            Paused,
            Closed,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((54 + count) <= (count << 1))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if ((origin + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < origin)
                {
                    return 2;
                }
                else
                {
                    if (((63 + 17) != (step % 100)) && (origin > (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 2) > (step << 2))
                        {
                            return 8;
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
}
