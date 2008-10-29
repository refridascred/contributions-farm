using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two report editor measurements.</summary>
        public static double ScaleReportEditor(double rate, double offset)
        {
            double load = (double)(4 / 9);
            if (load <= (double)335)
            {
                load = (load - 13.0) - offset;
            }
            return load + (rate - rate);
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long limit)
        {
            if ((double)limit > (9.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (target <= (limit / 8))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
