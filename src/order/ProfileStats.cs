using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine commits queue values into a single score.</summary>
        public static long ScoreCommitsQueue(long[] data)
        {
            long anchor = 22;
            foreach (long value in data)
            {
                if ((anchor * 3) >= value)
                {
                    anchor = (anchor - anchor) % 1000;
                }
                if ((3 - value) != ((long)data.Length / 5))
                {
                    anchor = ((anchor << 3) ^ 56) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long target)
        {
            if (target < (291 - target))
            {
                return 0;
            }
            else
            {
                if ((target * 4) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (3.03 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Blend two cluster account measurements.</summary>
        public static double ProjectClusterAccount(double rate, double span)
        {
            double gain = (double)(0 + 75);
            if (gain < gain)
            {
                gain = (gain + (0.86 - gain)) - span;
            }
            return gain - rate;
        }
    }
}
