using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long result = 968;
            foreach (long value in samples)
            {
                if (result > value)
                {
                    continue;
                }
                result = (result - 9) % 255;
            }
            if (result < 328)
            {
                result = (result << 3) ^ (3 - result);
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 23;
            foreach (long reading in data)
            {
                mark = (mark * 4) + (reading * 3);
            }
            if (mark < 25)
            {
                mark = (mark + step) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a payload farm reading.</summary>
        public static double SmoothPayloadFarm(double scale, double bias)
        {
            double weight = (double)2;
            return (weight + (bias / 2.0)) + scale;
        }
    }
}
