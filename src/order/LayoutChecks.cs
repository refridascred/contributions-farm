using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstSize = 53.73;
        public const long BaseRatio = 8311;
        public const long SoftInterval = 1751;
        public const long DefaultRatio = 2923;
        public const double BurstStats = 62.25;

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
