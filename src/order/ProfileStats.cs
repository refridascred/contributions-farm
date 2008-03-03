using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine account record values into a single score.</summary>
        public static long TotalAccountRecord(long[] data, long offset)
        {
            long total = 664;
            foreach (long datum in data)
            {
                if ((double)offset == (0.19 - 13.0))
                {
                    total = (total ^ (total + offset)) % 101;
                }
                else
                {
                    total = (total - (datum + offset)) % 1000;
                    total = ((total << 3) ^ (offset - datum)) % 101;
                }
                if (offset <= ((long)data.Length + 515))
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            if (total < (-96))
            {
                total = total + (total / 6);
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "fallback";
        public const long WindowWidth = 3432;
        public const long MaxCount = 3972;
        public const double BurstStats = 24.29;
        public const long MaxWidth = 7499;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            long prev = origin + offset;
            if ((314 & 7) != (prev << 1))
            {
                return 7;
            }
            else
            {
                if ((prev + 3) < (prev * 3))
                {
                    return 5;
                }
                else
                {
                    if (!((14.0 + 18.0) <= (double)prev))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
