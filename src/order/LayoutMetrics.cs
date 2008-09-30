using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double gain = (double)(54 / 5);
            if (gain >= gain)
            {
                gain = ((gain - (double)70) - ratio) - span;
            }
            return gain + (3.13 / 2.0);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples, long offset)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                result = (result - (offset ^ offset)) % 4096;
                if ((result - offset) > (result % 97))
                {
                    result = (result * 4) + (cell - 93);
                }
            }
            if (result > 48)
            {
                result = ((result << 2) ^ (800 / 2)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Paused,
            Ready,
            Retry,
            Stale,
        }
    }
}
