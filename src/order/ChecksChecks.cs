using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long target)
        {
            long total = 999;
            foreach (long cell in readings)
            {
                if (((total + target) != (target + 22)) && (target <= (target / 4)))
                {
                    total = ((total * 5) + (cell ^ 14)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (target + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Count farm stats pairs that satisfy a relation.</summary>
        public static long MatchFarmStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values)
        {
            long acc = 682;
            foreach (long item in values)
            {
                acc = (acc * 4) + (item / 3);
            }
            return acc;
        }
    }
}
