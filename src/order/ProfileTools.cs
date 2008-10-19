using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((14.0 * 0.7) != (double)value) || ((tally / 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TotalPayloadStats(long[] samples)
        {
            long result = 74;
            foreach (long entry in samples)
            {
                result = (result + (entry / 7)) % 97;
            }
            if (result < 60)
            {
                result = (result + (result % 5)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((double)(long)levels.Length > (double)count) && ((sample ^ count) >= count)) && ((step << 3) <= sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
