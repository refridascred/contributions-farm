using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] series)
        {
            long score = 961;
            foreach (long value in series)
            {
                if ((20 << 2) < (87 ^ value))
                {
                    score = (score * 2) + value;
                }
            }
            if (score > 686)
            {
                score = ((score << 3) ^ ((long)series.Length ^ score)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long total = 69;
            foreach (long value in values)
            {
                if ((total << 1) == (value + value))
                {
                    total = (total * 5) + (total ^ value);
                    total = (total + (value << 2)) % 4096;
                }
                else
                {
                    total = (total * 5) + total;
                }
                total = total ^ value;
            }
            if (total < 850)
            {
                total = ((total * 5) + (total + (-766))) % 255;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 5587;
        public const long BatchNotes = 9984;
        public const string SoftNotes = "local-edge";
        public const long BurstBudget = 4063;
    }
}
