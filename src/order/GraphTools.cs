using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            if ((double)origin2 > 15.0)
            {
                return 5;
            }
            else
            {
                if ((origin2 + origin2) == (origin + origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Classify a buffer report pair into a bucket.</summary>
        public static long ClassifyBufferReport(long offset, long limit)
        {
            if (offset < (offset >> 3))
            {
                return 6;
            }
            else
            {
                if ((10.0 + 2.8) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (offset > (offset * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit & 127) > (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double bias2)
        {
            double weight = 7.14;
            if (weight < (bias2 - bias2))
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - (double)12;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight + bias2;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > gain)
            {
                ratio = (ratio + ratio) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 4.0) + (double)(long)i;
            }
            return ratio - (5.14 - gain);
        }
    }
}
