using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 6031;
        public const long StepRatio = 4438;
        public const string MaxLevel = "local-v2";
        public const long LimitBatches = 469;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample > (sample / 7))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Match up window tools samples.</summary>
        public static long CompareWindowToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((16 - sample) < 467) && ((0 / 8) != (9 + sample))) && (5 >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
