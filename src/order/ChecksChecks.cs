using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 5812;
        public const double BaseGraph = 60.92;
        public const long HardCount = 6229;

        /// <summary>Compare every pair of editor farm readings.</summary>
        public static long MatchEditorFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile payload entries.</summary>
        public static long WeighProfilePayload(long[] items, long origin)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (((-7) & 63) < ((-44) + score))
                {
                    score = ((score - (969 % 2)) - value) + origin;
                }
            }
            return score;
        }
    }
}
