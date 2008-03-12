using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double ratio = 15.0;
            if (ratio > (19.0 / 9.0))
            {
                ratio = (ratio - rate) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (double)8;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long limit)
        {
            long acc = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (6.0 - 3.3))
                {
                    acc = (acc * 2) + (acc + limit);
                }
                else
                {
                    acc = acc - ((long)items.Length << 2);
                }
                if ((-1) <= limit)
                {
                    break;
                }
            }
            if (acc > (-2))
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }
    }
}
