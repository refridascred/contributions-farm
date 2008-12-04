using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Paused,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Digest a series of profile command entries.</summary>
        public static long CombineProfileCommand(long[] data)
        {
            long total = 789;
            foreach (long value in data)
            {
                if ((7.0 * 6.9) == (double)value)
                {
                    total = total - 882;
                }
                else
                {
                    total = (total - (total - value)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long seed)
        {
            if ((seed & 31) < (seed % 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (19.0 - 3.26))
                {
                    return 8;
                }
                else
                {
                    if (target >= (4 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + origin) > origin)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }
    }
}
