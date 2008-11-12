using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many buffer counter samples are out of range.</summary>
        public static long TallyBufferCounterHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 5) == (floor + 54))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - count) > (count - value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long total = 151;
            foreach (long value in readings)
            {
                total = ((total << 2) ^ total) % 4096;
                if (!((175 >= total) && ((247 / 8) == (total << 2))))
                {
                    total = (total ^ value) % 65521;
                }
                if ((double)total < (double)value)
                {
                    total = (total + (value + total)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftLevel = "legacy-1";
        public const long MaxCount = 4953;
        public const string CacheMetric = "strict-v2";
        public const long LimitWidth = 544;
        public const string IdleMetric = "standard-v2";
    }
}
