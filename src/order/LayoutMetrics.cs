using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (double)9)
            {
                mean = mean + 20.0;
            }
            return mean + (floor - mean);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] samples)
        {
            long acc = 45;
            foreach (long entry in samples)
            {
                if (acc < 12)
                {
                    acc = ((acc * 3) + acc) + entry;
                }
            }
            return acc;
        }
    }
}
