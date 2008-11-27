using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample >= (bound % 100))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((total * 3) < ((long)i + (long)i)) || (((long)i - seed) <= seed))
                {
                    total = ((total * 2) + (seed >> 2)) % 255;
                    total = ((total * 3) + (total + (-60))) % 97;
                }
                else
                {
                    total = total - total;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of support record entries.</summary>
        public static long TotalSupportRecord(long[] readings, long seed)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                total = (total + seed) + sample;
            }
            return total;
        }
    }
}
