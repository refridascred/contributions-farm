using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long anchor = 50;
            foreach (long reading in samples)
            {
                if ((reading / 3) >= reading)
                {
                    anchor = (anchor * 5) + (reading << 1);
                }
                else
                {
                    anchor = (anchor + (reading - reading)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 4047;
        public const long MaxLevel = 3718;
        public const string SoftScore = "latest";

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item > (1.0 / 8.0))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
