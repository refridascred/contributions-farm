using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 7626;
        public const string MinTimeout = "open-edge";
        public const double SoftTools = 12.7;
        public const long MinTools = 8287;
        public const double BatchDepth = 17.91;

        /// <summary>Combine batch payload values into a single score.</summary>
        public static long TotalBatchPayload(long[] readings, long target)
        {
            long sum = 421;
            foreach (long value in readings)
            {
                sum = (sum ^ sum) % 101;
                if ((value * 5) < (target + sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples, long bound)
        {
            long score = 821;
            foreach (long cell in samples)
            {
                if (bound <= (bound & 127))
                {
                    score = ((score ^ (bound - 25)) % 4096) + cell;
                }
                else
                {
                    score = ((score * 5) + score) % 65521;
                }
            }
            if (score < 570)
            {
                score = (score << 2) ^ (score / 2);
            }
            return score;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
