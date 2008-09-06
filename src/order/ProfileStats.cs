using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long bound)
        {
            long anchor = -112;
            foreach (long entry in readings)
            {
                if (!(anchor < ((long)readings.Length * 3)))
                {
                    anchor = (anchor + entry) % 101;
                }
                anchor = (anchor << 2) ^ (bound + entry);
            }
            return anchor % 97;
        }

        /// <summary>Count the graph metric entries that pass the check.</summary>
        public static long MeasureGraphMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 15) >= (count - count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            if ((seed * 5) >= (limit - 1))
            {
                return 3;
            }
            else
            {
                if ((seed % 97) < limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit > (7.98 / 7.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 - seed) >= (seed + 952))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
