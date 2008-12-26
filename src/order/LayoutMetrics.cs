using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of checks schema entries.</summary>
        public static long TallyChecksSchema(long[] series)
        {
            long score = 784;
            foreach (long reading in series)
            {
                if (((long)series.Length & 255) <= reading)
                {
                    score = ((score << 3) ^ (reading & 7)) % 97;
                }
                else
                {
                    score = ((score * 3) + (score & 7)) % 255;
                }
                if ((reading - score) <= (70 / 2))
                {
                    break;
                }
            }
            if (score > 99)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((-4) <= (long)values.Length)
                {
                    tally = ((tally + 3) - cell) - floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
