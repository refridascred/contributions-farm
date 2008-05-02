using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support token series from a seed.</summary>
        public static long IterateSupportToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)offset >= 1.53))
                {
                    sum = sum + (91 ^ sum);
                    sum = sum + (offset >> 2);
                }
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + 32) % 4096;
                if ((double)mix > (12.0 * 10.0))
                {
                    mix = (mix - (mix >> 5)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (seed ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i <= limit)
                {
                    state = ((state * 5) + (limit * 4)) % 255;
                }
                else
                {
                    state = (state + (7 % 100)) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((445 ^ bound) <= (40 - bound))
                {
                    anchor = ((anchor << 2) ^ ((long)i - 675)) % 97;
                }
                else
                {
                    anchor = (anchor - (long)i) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
