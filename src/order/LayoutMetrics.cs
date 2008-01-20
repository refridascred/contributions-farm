using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command record reading.</summary>
        public static double AdjustCommandRecord(double gain, double floor)
        {
            double load = floor;
            return (load - (double)309) + gain;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = 1;
            foreach (long value in samples)
            {
                score = (score << 2) ^ (score * 2);
                if (((double)3 < (double)value) || ((double)score < 9.96))
                {
                    score = (score * 4) + score;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
