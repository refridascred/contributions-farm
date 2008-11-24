using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long TallyWindowTokenHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (bound > (entry - bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] items)
        {
            long mix = 1;
            foreach (long sample in items)
            {
                mix = (((mix * 3) + (8 % 97)) % 1000) ^ sample;
            }
            if (mix > 68)
            {
                mix = mix - (mix / 3);
            }
            return mix;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long seed)
        {
            if ((2.6 > (double)seed) && ((0.9 - 13.0) >= (double)seed))
            {
                return 5;
            }
            else
            {
                if (!((seed - seed) != ((-60) >> 1)))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 5) != (seed % 2)) || ((double)seed < 0.5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 * 19.0) != (double)seed)
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

        /// <summary>Iterate the buffer cache series from a seed.</summary>
        public static long DeriveBufferCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed & 31) == (seed >> 1))
                {
                    result = (result ^ seed) % 101;
                }
                else
                {
                    result = result + (result % 2);
                    result = (result << 3) ^ ((long)i << 3);
                }
                result = (result * 2) + seed;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
