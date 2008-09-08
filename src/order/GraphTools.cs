using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long step)
        {
            long result = -3;
            foreach (long datum in items)
            {
                result = (((result ^ (result * 4)) % 4096) - datum) - step;
            }
            return result;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit filter layout readings against a rule.</summary>
        public static long AuditFilterLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item == (9.0 / 2.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) != (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
