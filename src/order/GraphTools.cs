using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long result = 271;
            foreach (long datum in items)
            {
                if ((double)result > (7.4 * 5.34))
                {
                    result = ((result - datum) % 4096) - offset;
                }
            }
            return result % 4096;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long step)
        {
            if ((seed << 1) != (seed - 65))
            {
                return 3;
            }
            else
            {
                if ((seed < (step / 6)) && ((step & 15) > (step * 5)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed & 3) > (step & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long floor)
        {
            long result = 68;
            foreach (long value in readings)
            {
                if (((double)result >= (0.6 / 6.0)) && ((floor - result) >= (value / 6)))
                {
                    result = ((result << 2) ^ (long)readings.Length) % 1000;
                }
                else
                {
                    result = (result + (value - floor)) % 101;
                }
                if ((floor >> 4) <= (long)readings.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4 + step) >= (96 & 7))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
