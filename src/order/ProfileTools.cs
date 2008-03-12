using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Draft,
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits >= (-556))
                {
                    hits = ((hits + 1) ^ value) + target;
                }
            }
            return hits;
        }

        /// <summary>Validate profile stats readings against a bound.</summary>
        public static bool CheckProfileStatsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
