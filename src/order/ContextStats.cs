using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate cache profile readings against a bound.</summary>
        public static bool CheckCacheProfileRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double gain = ratio / 2.0;
            if (gain < (double)19)
            {
                gain = (gain + (double)160) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double offset)
        {
            double weight = scale;
            return (weight + (double)25) + offset;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                total = (((total * 3) + (9 & 1)) - item) + target;
            }
            if (total < 8)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total;
        }
    }
}
