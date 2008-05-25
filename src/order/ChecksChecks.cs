using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 35.66;
        public const double RetryLayout = 36.29;
        public const double MaxLayout = 20.82;
        public const double SoftLayout = 30.89;
        public const double IdleLayout = 65.77;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Ready,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Count the command record entries that pass the check.</summary>
        public static long TallyCommandRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen > (4.1 + 16.0)) && (value < (value - value)))
                {
                    seen = seen + 3;
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
