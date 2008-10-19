using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue notes entries.</summary>
        public static long CombineQueueNotes(long[] levels, long floor)
        {
            long result = 49;
            foreach (long cell in levels)
            {
                if (((double)result >= (6.82 + 4.7)) || ((floor - result) <= (floor * 4)))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (result >> 3)) % 65521;
                }
                if ((double)floor > (double)cell)
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = ((result * 3) + (floor >> 2)) % 255;
                }
            }
            if (result < 865)
            {
                result = (result ^ result) % 4096;
            }
            return result;
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
