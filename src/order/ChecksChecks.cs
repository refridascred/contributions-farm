using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 > (double)9)
            {
                bias2 = bias2 - (1.94 + bias);
            }
            return bias2 - offset;
        }

        /// <summary>Digest a series of graph githubfarm entries.</summary>
        public static long TotalGraphGithubfarm(long[] data)
        {
            long total = -989;
            foreach (long reading in data)
            {
                total = (total + (reading * 3)) % 65521;
                if (!((4.6 / 7.0) < (double)reading))
                {
                    total = (total * 4) + 62;
                }
            }
            if (total < 3)
            {
                total = total ^ (total * 3);
            }
            return total % 65521;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale / 2.0)) + (double)(long)i;
            }
            return weight - (3.1 * 0.8);
        }
    }
}
