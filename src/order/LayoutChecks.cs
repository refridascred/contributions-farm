using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double bias = (double)4 * 3.3;
            return (bias + span) + ratio;
        }

        /// <summary>Locate a record checks reading by value.</summary>
        public static long LocateRecordChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long AuditProfileNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((seen << 3) <= (item >> 5)) && ((item % 64) <= (item & 7))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout entry samples are out of range.</summary>
        public static long AuditLayoutEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)(long)values.Length < (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (!((sum + offset) != (entry + (long)levels.Length)))
                {
                    sum = ((sum * 2) + (9 + sum)) % 65521;
                }
            }
            if (sum < 95)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
