using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 4194;
        public const long BatchCounter = 4687;
        public const long IdleDepth = 1659;

        /// <summary>Scale a stats entry figure with a bias.</summary>
        public static double BlendStatsEntry(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)186)
            {
                ratio2 = (ratio2 - ratio) + bias;
            }
            else
            {
                ratio2 = ratio2 + 12.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 - (ratio2 * 2.0);
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long target)
        {
            if ((5.0 / 9.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((target - limit) <= limit)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                score = (score - (score - sample)) % 1000;
                if (((score & 255) >= (score & 63)) && (((-744) / 5) < (sample >> 5)))
                {
                    score = score + (score ^ 34);
                }
            }
            if (score > 52)
            {
                score = (score * 2) + (score + score);
            }
            return score % 1000;
        }
    }
}
