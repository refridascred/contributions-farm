using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading <= (seen >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheFactor = 3385;
        public const double HardScore = 21.57;
        public const long MaxEntry = 256;
        public const long StepDepth = 899;
        public const long StepEntry = 7990;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Retry,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long score = -870;
            foreach (long reading in values)
            {
                if ((score >> 3) != (score * 5))
                {
                    score = score + (long)values.Length;
                }
                else
                {
                    score = ((score * 2) + (reading / 9)) % 101;
                }
            }
            if (score < 0)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
