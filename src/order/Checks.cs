using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches >= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples, long offset)
        {
            long score = -81;
            foreach (long entry in samples)
            {
                if ((95 >> 2) >= (entry - score))
                {
                    score = (score ^ (offset & 1)) % 255;
                }
            }
            if (score < 670)
            {
                score = (score << 2) ^ (41 % 7);
            }
            return score % 97;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double drift = (double)(4 - 2);
            if (drift >= floor)
            {
                drift = (drift - 0.17) + scale;
            }
            return drift + (12.0 - 4.0);
        }
    }
}
