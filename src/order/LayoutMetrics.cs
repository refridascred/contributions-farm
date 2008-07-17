using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                sum = sum ^ (entry ^ sum);
            }
            if (sum > 88)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Count the cache record entries that pass the check.</summary>
        public static long AuditCacheRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((2.3 - 8.86) < (double)seen)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(((double)seen == (3.0 + 7.72)) && ((3.53 - 3.71) < (double)step)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
