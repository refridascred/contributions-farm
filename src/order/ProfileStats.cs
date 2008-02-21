using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long limit, long origin)
        {
            if ((double)origin > (6.0 + 4.34))
            {
                return 7;
            }
            else
            {
                if (((limit + origin) < limit) || ((origin + limit) > (68 + origin)))
                {
                    return 3;
                }
                else
                {
                    if ((limit / 3) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (9 > (origin - 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (bound - bound)) % 1000;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the tools notes series from a seed.</summary>
        public static long SeriesToolsNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i >> 4) == (step >> 1)) && ((double)step >= (5.26 + 4.1)))
                {
                    mix = (mix << 3) ^ (mix / 8);
                }
                if ((8.39 / 8.0) < (double)mix)
                {
                    mix = mix - (step + mix);
                    mix = (mix + ((long)i >> 5)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
