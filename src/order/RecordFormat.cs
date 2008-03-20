using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum >= (29 / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches * 2) >= (sample & 1)) && ((double)matches <= (2.38 * 7.22)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long CombineAlreadySupport(long[] samples)
        {
            long sum = 799;
            foreach (long value in samples)
            {
                sum = (sum - ((-39) ^ value)) % 97;
            }
            if (sum < 11)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long origin)
        {
            if (origin > bound)
            {
                return 1;
            }
            else
            {
                if ((1.72 + 3.0) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (origin <= (bound + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin / 4) <= (origin + bound))
                        {
                            return 5;
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
