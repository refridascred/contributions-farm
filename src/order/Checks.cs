using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if (bound < (limit ^ 342))
            {
                return 6;
            }
            else
            {
                if ((4.51 * 2.2) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 5) > (9 ^ 970))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit ^ limit) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm route samples.</summary>
        public static long WeighGithubfarmRoute(long[] items)
        {
            long mix = 90;
            foreach (long datum in items)
            {
                mix = ((mix - (mix / 8)) % 1000) ^ datum;
            }
            return mix;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit * 3) == (limit + mark)) && (85 < ((long)i + limit)))
                {
                    mark = ((mark << 2) ^ (mark % 3)) % 4096;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((8 % 7) < (offset + offset))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the window report series from a seed.</summary>
        public static long SeriesWindowReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i >= (17.0 * 4.28))
                {
                    score = ((score << 3) ^ (8 + bound)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
