using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long floor, long target)
        {
            if ((5.43 * 10.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if ((target + floor) <= target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 3) <= (cell + cell))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
