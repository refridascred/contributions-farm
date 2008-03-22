using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 2951;
        public const long DefaultAccount = 7302;
        public const double SoftRatio = 76.82;
        public const long HardTimeout = 9447;
        public const long RetryRatio = 412;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - seen) <= (seen + (long)items.Length))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(matches > (8 / 8)) && ((1 & 1) < (matches / 3)))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}
