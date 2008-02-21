using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Blend two payload account measurements.</summary>
        public static double SmoothPayloadAccount(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)61)
            {
                ratio2 = (ratio2 - 1.8) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 + (ratio2 / 4.0);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long step)
        {
            long score = 58;
            foreach (long item in levels)
            {
                if ((item / 6) <= score)
                {
                    score = (score ^ (item >> 2)) % 101;
                }
                else
                {
                    score = (score + (score + score)) % 1000;
                }
                if ((score % 10) <= (item + step))
                {
                    break;
                }
            }
            if (score < 99)
            {
                score = (score - (step + score)) % 65521;
            }
            return score % 65521;
        }
    }
}
