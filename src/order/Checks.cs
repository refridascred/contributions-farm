using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - 2) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long TallyEntrySchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - 5) < (4 + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a window metric value against two limits.</summary>
        public static long GradeWindowMetric(long target, long offset)
        {
            if (offset > (offset ^ target))
            {
                return 3;
            }
            else
            {
                if ((offset >> 5) <= (offset - target))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 3) <= (offset * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                if ((7.5 * 4.9) >= (double)reading)
                {
                    carry = ((carry << 2) ^ (reading >> 1)) % 4096;
                }
                else
                {
                    carry = carry ^ (carry * 5);
                }
            }
            return carry;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset + floor) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if (floor < (floor & 31))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
