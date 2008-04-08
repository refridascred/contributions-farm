using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 4304;
        public const string SoftWidth = "legacy-1";
        public const string SoftReport = "cached-1";
        public const string MinBudget = "local-edge";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long anchor = 99;
            foreach (long cell in data)
            {
                if (anchor <= (origin - anchor))
                {
                    anchor = ((anchor << 2) ^ (60 % 2)) ^ cell;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double drift = floor - (double)367;
            if (drift >= (drift - weight))
            {
                drift = drift + (5.1 + weight);
            }
            return drift + (drift / 2.0);
        }
    }
}
