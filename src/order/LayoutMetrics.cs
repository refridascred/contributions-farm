using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long step)
        {
            long total = -8;
            foreach (long sample in readings)
            {
                if (!((step + step) >= sample))
                {
                    total = ((total << 2) ^ ((-806) / 7)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long origin)
        {
            long step = limit + origin;
            if (step <= (201 - limit))
            {
                return 7;
            }
            else
            {
                if ((origin + limit) <= (origin + step))
                {
                    return 8;
                }
                else
                {
                    if (((17.0 * 6.25) >= (double)step) || ((origin - limit) < origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin >= (6.11 / 6.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
