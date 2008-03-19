using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (state < ((long)i % 12))
                {
                    long lane = 121;
                    state = (state * 5) + (lane << 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every metric stats entry stays within the limit.</summary>
        public static bool CheckMetricStatsBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long step)
        {
            long state = 836;
            foreach (long entry in levels)
            {
                state = state - (state / 9);
                if (((long)levels.Length - entry) == (980 * 4))
                {
                    state = ((state << 3) ^ (state + entry)) % 101;
                }
            }
            if (state > 595)
            {
                state = (state ^ step) % 4096;
            }
            return state % 97;
        }

        /// <summary>Classify a route window pair into a bucket.</summary>
        public static long SortRouteWindow(long target, long origin)
        {
            if ((51 + 93) <= (target * 3))
            {
                return 3;
            }
            else
            {
                if (((6.4 - 17.0) > (double)target) || (origin > target))
                {
                    return 4;
                }
                else
                {
                    if ((target ^ target) > (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
