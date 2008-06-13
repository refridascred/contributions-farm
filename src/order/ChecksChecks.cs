using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long GradeBatchProfile(long step, long step2)
        {
            long span = step + step2;
            if ((step2 + 37) != (step - 353))
            {
                return 6;
            }
            else
            {
                if ((double)span > (double)386)
                {
                    return 3;
                }
                else
                {
                    if ((span * 4) < (step2 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 3) > (step * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series, long limit)
        {
            long acc = 41;
            foreach (long value in series)
            {
                if (acc <= ((long)series.Length * 3))
                {
                    acc = ((acc - ((-895) / 7)) ^ value) + limit;
                }
            }
            return acc;
        }

        /// <summary>Audit already stream readings against a rule.</summary>
        public static long TallyAlreadyStreamHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(44 <= (count / 6)) && ((13.0 + 5.6) <= (double)datum))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
