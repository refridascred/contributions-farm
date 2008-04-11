using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Synced,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long step)
        {
            long edge = offset - step;
            if (((0.5 + 5.5) != (double)offset) || ((edge / 9) != (0 * 4)))
            {
                return 7;
            }
            else
            {
                if (((step ^ edge) >= (offset / 5)) || ((965 >> 1) >= (offset % 12)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Paused,
            Stale,
        }
    }
}
