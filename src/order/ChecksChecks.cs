using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long lane = step + offset;
            if (!(4.3 <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (!((offset >> 3) <= lane))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples, long offset)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                anchor = ((anchor + offset) % 4096) + entry;
            }
            if (anchor > 842)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
