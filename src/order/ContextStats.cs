using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count ^ count) > (count % 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next context tools value from a seed.</summary>
        public static long StepContextTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + origin) % 255;
                if ((sum << 3) > ((long)i + 779))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long TallyFilterTokenMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample ^ sample) < ((-666) * 5)) || !((9.0 * 1.1) != (double)hits))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long bound2)
        {
            long slot = bound - bound2;
            if ((5.49 + 2.8) == (double)slot)
            {
                return 7;
            }
            else
            {
                if (!((14.0 - 2.9) >= (double)bound2))
                {
                    return 2;
                }
                else
                {
                    if (((bound + bound) != (bound2 * 3)) && ((slot / 8) < (bound + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - 546) < (slot << 3)) || ((4.5 - 7.8) < (double)bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
