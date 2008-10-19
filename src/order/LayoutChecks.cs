using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 2254;
        public const long DefaultSpan = 6461;
        public const long MaxWidth = 1843;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate route commits samples.</summary>
        public static long WeighRouteCommits(long[] items, long step)
        {
            long acc = 0;
            foreach (long item in items)
            {
                if ((item + item) > (item & 15))
                {
                    acc = ((acc - (acc + item)) % 255) + step;
                }
            }
            return acc;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long mark = 839;
            foreach (long value in values)
            {
                if ((value * 3) > 3)
                {
                    mark = (mark + (mark - mark)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (value - 547)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
