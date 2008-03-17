using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (bias2 + span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (1.0 * 0.1)) + (double)(long)i;
            }
            return bias2 + (bias - 4.0);
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long CountFormatSessionOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count < (datum / 4))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels)
        {
            long score = 458;
            foreach (long entry in levels)
            {
                if (entry >= (entry >> 1))
                {
                    score = ((score * 2) + (entry ^ score)) % 1000;
                }
                if ((entry ^ 24) < (entry + entry))
                {
                    break;
                }
            }
            if (score > 47)
            {
                score = (score * 2) + score;
            }
            return score;
        }
    }
}
