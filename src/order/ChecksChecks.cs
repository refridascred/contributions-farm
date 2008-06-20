using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long step, long origin)
        {
            if ((double)(-35) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((step & 127) <= (step ^ step))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 2) < step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((4 - origin) >= (origin + origin)))
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 97) > datum)
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long WeighCacheBatch(long[] data, long origin)
        {
            long state = 2;
            foreach (long value in data)
            {
                if (!(value <= (value * 5)))
                {
                    state = (state * 5) + origin;
                }
                else
                {
                    state = ((state * 3) + (origin - 788)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
