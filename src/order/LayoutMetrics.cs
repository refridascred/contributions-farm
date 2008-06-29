using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 8592;
        public const string SoftDepth = "local-1";
        public const double CacheNotes = 19.25;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples)
        {
            long score = 629;
            foreach (long sample in samples)
            {
                if (sample >= score)
                {
                    score = score - (sample % 2);
                }
                score = score + score;
            }
            if (score < 83)
            {
                score = ((score << 3) ^ (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
