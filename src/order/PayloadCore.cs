using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long StepOrderMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i != (bound + score))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score * 3) + (bound + score)) ^ (long)i2;
                }
                score = (score ^ ((long)i ^ (-82))) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long total = 80;
            foreach (long entry in readings)
            {
                total = (total ^ (entry & 31)) % 4096;
            }
            return total;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (16 <= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((bound ^ bound3) <= (bound3 + bound3))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound3) < (bound2 * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Synced,
            Idle,
        }
    }
}
