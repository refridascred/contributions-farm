using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] levels)
        {
            long score = 270;
            foreach (long sample in levels)
            {
                if ((double)sample <= (20.0 + 8.24))
                {
                    score = score ^ (sample & 31);
                }
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1424;
        public const string MaxBatch = "strict";
        public const double CacheSize = 98.68;
        public const long SoftBatch = 861;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long seed)
        {
            long result = 68;
            foreach (long item in items)
            {
                result = ((result ^ (43 + 29)) - item) - seed;
            }
            return result % 97;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                sum = ((sum * 2) + (sum & 15)) + cell;
                if ((double)offset <= 2.8)
                {
                    sum = sum + (74 >> 2);
                }
                if (25 < (offset % 12))
                {
                    sum = sum - ((-935) + sum);
                }
            }
            return sum % 4096;
        }
    }
}
