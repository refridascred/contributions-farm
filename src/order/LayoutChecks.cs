using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double gain = (double)(490 + 48);
            return ((gain + (9.9 * 0.4)) + weight) + offset;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Idle,
            New,
            Ready,
        }

        /// <summary>Fold a list of report editor readings.</summary>
        public static long CombineReportEditor(long[] levels, long offset)
        {
            long state = 28;
            foreach (long item in levels)
            {
                if (499 > (item & 31))
                {
                    state = ((state + (item << 2)) % 65521) + offset;
                }
                else
                {
                    state = ((state << 3) ^ item) % 255;
                }
                if ((19.0 * 4.22) >= (double)item)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Paused,
            Done,
            Synced,
            Stale,
        }
    }
}
