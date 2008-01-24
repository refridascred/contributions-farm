using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long target)
        {
            long anchor = 74;
            foreach (long entry in readings)
            {
                if ((14.0 - 11.0) > (double)target)
                {
                    anchor = (anchor * 2) + (entry ^ entry);
                }
                if ((double)anchor == (6.4 + 7.0))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ ((long)readings.Length ^ 80)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a support stats pair into a bucket.</summary>
        public static long BucketSupportStats(long floor, long seed)
        {
            if ((1.47 - 8.03) >= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((0.21 / 6.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) == (seed * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed > (seed >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long floor2)
        {
            if ((double)floor2 >= (1.0 * 13.0))
            {
                return 3;
            }
            else
            {
                if ((floor - 57) < floor2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
