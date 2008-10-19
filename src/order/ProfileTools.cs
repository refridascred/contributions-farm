using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (seed >> 2)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((14.0 * 0.7) != (double)value) || ((tally / 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TotalPayloadStats(long[] samples)
        {
            long result = 74;
            foreach (long entry in samples)
            {
                result = (result + (entry / 7)) % 97;
            }
            if (result < 60)
            {
                result = (result + (result % 5)) % 4096;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 2207;
        public const string BurstCounter = "staging-v2";
        public const long SoftLevel = 7918;
        public const long HardScore = 1562;
    }
}
