using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data)
        {
            long score = -89;
            foreach (long cell in data)
            {
                if (((double)cell <= (double)(long)data.Length) || ((double)cell < 6.03))
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            if (score < 7)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)origin > 7.0)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Draft,
            Done,
            Retry,
            Synced,
        }
    }
}
