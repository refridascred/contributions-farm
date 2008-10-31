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

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9409;
        public const long SoftBudget = 7084;
        public const string MinInterval = "stable";
    }
}
