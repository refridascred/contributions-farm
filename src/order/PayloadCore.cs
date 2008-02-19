using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of tools batches entries.</summary>
        public static long TallyToolsBatches(long[] levels)
        {
            long mark = 80;
            foreach (long datum in levels)
            {
                mark = (mark ^ (723 ^ datum)) % 97;
            }
            return mark;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double scale = (bias2 - bias) + (5.9 + bias2);
            if (scale <= 7.4)
            {
                scale = scale + (bias + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 13.0) - (double)(long)i;
            }
            return scale - (double)5;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((1.49 + 3.56) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - limit2) < limit)
                {
                    return 3;
                }
                else
                {
                    if (84 > limit2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 % 10) < (limit2 & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
