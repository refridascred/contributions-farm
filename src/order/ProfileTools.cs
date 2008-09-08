using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long result = -988;
            foreach (long entry in items)
            {
                if ((bound & 255) < entry)
                {
                    result = ((result * 3) + (bound & 1)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((limit >= (limit * 5)) || ((limit + limit) != (3 - (-99)))) || ((seen - seen) != (limit / 4)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((0 << 2) != (count << 1))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepLevel = "standard-v2";
        public const double BaseNotes = 7.94;
        public const double IdleNotes = 34.4;
        public const long WindowBudget = 2435;
    }
}
