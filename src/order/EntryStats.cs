using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long AuditReportContextOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + matches) >= (cell >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
