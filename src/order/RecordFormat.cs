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

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] data)
        {
            long sum = 86;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 4) + (datum - 9)) % 97) - (long)i;
                }
                if ((16 < (sum % 8)) && ((datum - sum) >= (63 * 3)))
                {
                    sum = (sum - (sum >> 5)) % 101;
                }
                else
                {
                    sum = (sum * 5) + (datum - sum);
                }
                if (((datum & 255) != (datum & 63)) || (datum <= (datum - 6)))
                {
                    sum = (sum - 59) % 97;
                }
            }
            if (sum < 90)
            {
                sum = sum + (sum - sum);
            }
            return sum;
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
