using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next token channel value.</summary>
        public static double AdjustTokenChannel(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (rate + bias2))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + (5.77 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 5.0)) - (double)(long)i;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long origin)
        {
            long score = 4;
            foreach (long entry in series)
            {
                if (!((7 * 5) > (entry - entry)))
                {
                    score = ((score * 4) + (score % 3)) - origin;
                }
                if (!(entry >= (score >> 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Draft,
            Synced,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
