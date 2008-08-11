using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a cluster batches reading.</summary>
        public static double ScaleClusterBatches(double scale, double offset)
        {
            double rate = offset * 9.8;
            if (rate > (double)82)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + offset;
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
