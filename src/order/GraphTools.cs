using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long floor)
        {
            long span = step ^ floor;
            if ((double)floor > (8.22 + 1.3))
            {
                return 2;
            }
            else
            {
                if (span < (floor / 5))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long WeighCounterContext(long[] items)
        {
            long total = 75;
            foreach (long value in items)
            {
                if ((value - 70) <= (total + total))
                {
                    total = (total - ((long)items.Length * 5)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
