using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit >= score)
                {
                    continue;
                }
                else
                {
                    score = (score - (score - 367)) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long seed)
        {
            if ((seed >> 2) > (seed * 5))
            {
                return 7;
            }
            else
            {
                if (((seed % 12) <= (9 / 4)) && ((double)floor <= 0.67))
                {
                    return 5;
                }
                else
                {
                    if ((5.03 - 4.2) <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings, long origin)
        {
            long result = 3;
            foreach (long sample in readings)
            {
                result = ((result - result) % 97) - sample;
                if ((7.0 * 0.1) != (double)origin)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
