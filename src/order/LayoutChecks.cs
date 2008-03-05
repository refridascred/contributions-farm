using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings, long seed)
        {
            long result = 32;
            foreach (long datum in readings)
            {
                result = (((result * 4) + (result % 12)) % 101) - seed;
                result = (result << 3) ^ (datum + result);
                if ((double)datum < (9.0 * 2.8))
                {
                    break;
                }
            }
            if (result < 176)
            {
                result = result ^ (result * 2);
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 13.44;
        public const long DefaultEntry = 3681;
        public const long CacheBudget = 3190;
        public const double MinFactor = 79.63;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items, long target)
        {
            long acc = 40;
            foreach (long cell in items)
            {
                acc = ((acc * 5) + acc) - target;
                if ((double)cell < (5.0 + 12.0))
                {
                    acc = ((acc << 2) ^ (acc + cell)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
