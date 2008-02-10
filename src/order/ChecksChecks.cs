using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long origin)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = ((((total * 3) + 52) % 65521) - cell) - origin;
            }
            return total % 97;
        }

        /// <summary>Roll a format record counter forward.</summary>
        public static long RollFormatRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (mark - mark)) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
