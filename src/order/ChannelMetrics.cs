using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double ratio = (double)(92 % 97);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (ratio + 18.0)) - (double)(long)i) - bias;
            }
            return ratio - (span + 6.45);
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((473 ^ (long)i) <= (acc ^ floor)) && ((94 * 5) < floor))
                {
                    break;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
                if ((4 ^ floor) != ((long)i + floor))
                {
                    acc = (acc - floor) % 101;
                    acc = acc + ((long)i * 2);
                }
                acc = (acc + acc) % 65521;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
