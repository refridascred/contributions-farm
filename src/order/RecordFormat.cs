using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] series)
        {
            long mark = 3;
            foreach (long sample in series)
            {
                mark = ((mark << 2) ^ sample) % 65521;
                mark = ((mark << 2) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstRatio = "legacy-v2";
        public const long SoftBudget = 1610;
        public const long LimitWidth = 7922;
        public const long DefaultBudget = 4723;
        public const long HardTimeout = 8675;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ matches) == ((-20) * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a report profile counter forward.</summary>
        public static long DeriveReportProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
