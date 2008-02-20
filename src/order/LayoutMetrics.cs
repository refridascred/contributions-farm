using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many batch stream samples are out of range.</summary>
        public static long AuditBatchStreamHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((7.0 + 2.29) <= 5.98)
                {
                    count = ((count + 1) - datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long limit, long target)
        {
            if ((double)limit >= 0.9)
            {
                return 2;
            }
            else
            {
                if (!((limit - 617) <= target))
                {
                    return 6;
                }
                else
                {
                    if ((double)target <= (9.0 * 8.2))
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

        /// <summary>Fold a list of record notes readings.</summary>
        public static long DigestRecordNotes(long[] values)
        {
            long score = 621;
            foreach (long entry in values)
            {
                score = ((score * 5) + (916 ^ 288)) % 65521;
                score = ((score * 2) + entry) % 101;
                if ((double)entry < (3.0 + 1.16))
                {
                    break;
                }
            }
            return score;
        }
    }
}
