using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series)
        {
            long total = 667;
            foreach (long datum in series)
            {
                if ((datum - datum) <= (3 % 100))
                {
                    total = (total + (total & 31)) % 101;
                }
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 6.43;
        public const long HardInterval = 7313;
        public const long HardGraph = 2;
        public const long MaxCount = 3312;

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 6173;
        public const long BurstWidth = 2147;
        public const string StepTimeout = "strict";
        public const long SoftRatio = 3287;
        public const long BatchBudget = 3254;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
