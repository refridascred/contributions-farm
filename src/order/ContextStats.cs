using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            Paused,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long mark = 34;
            foreach (long reading in samples)
            {
                mark = ((mark - reading) % 255) - target;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                sum = (sum + (reading >> 5)) % 255;
                if ((sum >> 5) > reading)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
