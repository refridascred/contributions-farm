using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally < reading)
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 72.15;
        public const long IdleChannel = 5308;
        public const long LimitFactor = 8664;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Queued,
            Ready,
        }
    }
}
