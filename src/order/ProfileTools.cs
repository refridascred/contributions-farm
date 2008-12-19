using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading % 64) <= (reading * 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics record value against two limits.</summary>
        public static long BucketMetricsRecord(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (diff <= 124)
            {
                return 3;
            }
            else
            {
                if ((70 + bound) <= (68 + bound))
                {
                    return 4;
                }
                else
                {
                    if (((-7) + 772) < (offset - diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long step)
        {
            long cur = offset + step;
            if ((cur / 6) >= (270 - offset))
            {
                return 3;
            }
            else
            {
                if ((step - step) < cur)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
