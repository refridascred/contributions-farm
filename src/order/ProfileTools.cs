using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next githubfarm graph value.</summary>
        public static double AdjustGithubfarmGraph(double bias, double bias2)
        {
            double gain = bias - (bias2 * 11.0);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain * 10.0)) + (double)(long)i;
            }
            return gain - (double)23;
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 71.03;
        public const double MaxLayout = 14.41;
        public const long BurstSize = 3686;

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items)
        {
            long acc = 3;
            foreach (long reading in items)
            {
                if ((71 * 5) == (acc % 3))
                {
                    acc = ((acc ^ (-69)) % 4096) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "strict-edge";
        public const long WindowLevel = 7824;
        public const long MinOrder = 3779;
        public const double BurstTimeout = 22.56;
    }
}
