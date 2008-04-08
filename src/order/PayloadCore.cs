using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(hits < (value % 24)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Pending,
            Active,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 719;
        public const long WindowLevel = 5550;
        public const long DefaultRoute = 1860;
        public const long BatchBudget = 8529;
        public const double SoftScore = 96.16;
    }
}
