using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long acc = 417;
            foreach (long datum in series)
            {
                if (target < (datum >> 5))
                {
                    acc = ((acc << 3) ^ (acc << 1)) % 97;
                }
            }
            if (acc > 1)
            {
                acc = acc - (acc & 63);
            }
            return acc % 65521;
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

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
