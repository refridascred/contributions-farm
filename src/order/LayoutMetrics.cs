using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine window batches values into a single score.</summary>
        public static long ScoreWindowBatches(long[] samples, long limit)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (long)samples.Length) % 4096;
                anchor = anchor + (376 - limit);
                if ((datum + datum) <= (limit << 3))
                {
                    break;
                }
            }
            return anchor % 1000;
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
