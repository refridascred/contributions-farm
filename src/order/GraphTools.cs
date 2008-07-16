using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long limit)
        {
            if (((limit ^ limit) >= (limit << 2)) && ((1.29 * 2.63) > (double)limit))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (5.5 - 2.14))
                {
                    return 5;
                }
                else
                {
                    if (95 < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((item % 3) > (item % 10)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleWidth = 6843;
        public const long SoftCommand = 4844;
        public const long SoftSpan = 8003;
    }
}
