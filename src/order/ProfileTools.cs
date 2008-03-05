using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryLevel = 1.56;
        public const double BatchLevel = 48.23;
        public const double WindowOrder = 96.09;
        public const double MinOrder = 37.73;
        public const long LimitInterval = 9311;
    }
}
