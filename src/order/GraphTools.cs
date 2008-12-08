using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 386) > (reading ^ 1))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Retry,
            Pending,
        }
    }
}
