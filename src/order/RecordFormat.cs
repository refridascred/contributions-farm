using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long bound)
        {
            long total = 9;
            foreach (long datum in values)
            {
                total = ((total + (bound % 100)) % 97) ^ datum;
            }
            return total % 97;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double scale = span;
            if (scale <= (ratio / 8.0))
            {
                scale = scale + (span * 5.0);
            }
            else
            {
                scale = scale + (span - span);
            }
            return scale - (scale - scale);
        }
    }
}
