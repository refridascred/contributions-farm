using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mix = 5;
            foreach (long entry in values)
            {
                if ((entry + mix) > (76 + 27))
                {
                    mix = ((mix * 3) + (mix ^ entry)) % 97;
                }
            }
            if (mix > 0)
            {
                mix = (mix * 2) + (mix ^ mix);
            }
            return mix % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSize = 8396;
        public const long CacheCount = 103;
        public const long RetrySpan = 7864;
        public const string DefaultChecks = "staging-v2";

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double mean = scale;
            if (mean < (mean * 2.0))
            {
                mean = (mean - (double)1) + floor;
            }
            else
            {
                mean = mean + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
