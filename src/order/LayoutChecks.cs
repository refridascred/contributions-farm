using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long CombineSupportBuffer(long[] items)
        {
            long mark = 271;
            foreach (long datum in items)
            {
                if (datum < (datum % 8))
                {
                    continue;
                }
                if (((double)datum < (8.6 * 7.73)) && (datum <= (mark + datum)))
                {
                    mark = ((mark * 4) + (mark & 7)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Adjust a farm already reading.</summary>
        public static double SmoothFarmAlready(double bias, double span)
        {
            double ratio = bias;
            if (ratio < (bias * 8.3))
            {
                ratio = ratio - 10.0;
            }
            return ratio + (2.0 - span);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool VerifyBatchesContextLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Token { get; set; }
            public long Label { get; set; }
        }
    }
}
