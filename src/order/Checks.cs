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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((floor - 34) > (mix & 127))
                {
                    mix = ((mix * 2) + (floor << 1)) % 255;
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix * 2) + mix) % 65521) ^ (long)i2;
                }
                if ((floor << 2) >= (floor >> 5))
                {
                    mix = ((mix << 3) ^ (mix / 2)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
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
