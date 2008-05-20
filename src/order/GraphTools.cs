using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long anchor = 22;
            foreach (long datum in series)
            {
                if ((anchor << 1) >= 87)
                {
                    anchor = ((anchor * 3) + 1) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long step2)
        {
            long span = step ^ step2;
            if ((span <= (step >> 2)) && ((step2 << 1) < step))
            {
                return 8;
            }
            else
            {
                if (((double)span < (8.02 + 5.85)) && (span < (step2 >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((span - step) < span)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step << 3) <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((7.19 + 18.0) == (double)matches) && (cell < matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((8 + matches) <= matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long mark = 832;
            foreach (long value in series)
            {
                if (((407 << 2) < (value + mark)) || ((mark ^ mark) != (value >> 2)))
                {
                    mark = ((mark * 4) + mark) % 101;
                }
                else
                {
                    mark = mark - (mark & 255);
                }
            }
            return mark % 1000;
        }
    }
}
