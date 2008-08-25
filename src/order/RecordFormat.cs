using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((91 + value) != (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long limit)
        {
            long mark = 18;
            foreach (long item in levels)
            {
                mark = (mark - (item / 9)) - limit;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleCount = 68.24;
        public const long DefaultDepth = 1757;
        public const long MinBuffer = 6301;
        public const double BatchDepth = 14.3;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 2) + (bound & 31)) % 4096) - (long)i2;
                    total = ((total << 3) ^ (total + total)) % 101;
                }
                total = (total << 3) ^ (bound ^ bound);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
