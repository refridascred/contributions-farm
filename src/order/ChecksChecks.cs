using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long target)
        {
            long score = -128;
            foreach (long cell in series)
            {
                if (((cell >> 3) == (target + score)) || (score > (score + 546)))
                {
                    score = (score + (target + 787)) % 1000;
                }
            }
            if (score < 67)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double scale = (double)(18 ^ 58);
            if (scale >= 0.05)
            {
                scale = (scale - (9.0 - offset)) + gain;
            }
            return scale - 18.0;
        }

        /// <summary>Find the first checks context entry that matches the target.</summary>
        public static long LookupChecksContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
