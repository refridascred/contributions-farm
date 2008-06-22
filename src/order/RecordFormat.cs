using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count - cell) > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 1205;
        public const long RetryChecks = 5515;
        public const long SoftWidth = 4329;
        public const long SoftChecks = 3273;

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long IterateContributiEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((total * 5) > (total >> 1)))
                {
                    total = ((total << 2) ^ 604) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            if ((offset / 9) <= (57 % 24))
            {
                return 8;
            }
            else
            {
                if ((offset + floor) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= 6.8)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
