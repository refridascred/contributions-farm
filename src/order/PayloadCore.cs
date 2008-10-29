using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long origin)
        {
            if ((double)origin <= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)origin != (15.0 - 9.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if (((double)step > (double)690) || ((sum / 6) == (sum % 100)))
                {
                    continue;
                }
                else
                {
                    sum = (sum + sum) % 255;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Audit record filter readings against a rule.</summary>
        public static long CountRecordFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((hits + hits) != (hits << 1)))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
