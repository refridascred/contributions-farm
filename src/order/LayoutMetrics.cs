using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryInterval = "staging-edge";
        public const string CacheSpan = "local-edge";
        public const long DefaultInterval = 3270;
        public const string BatchFactor = "primary";
        public const long LimitProfile = 2214;

        /// <summary>Scale a editor queue figure with a bias.</summary>
        public static double SmoothEditorQueue(double ratio, double offset)
        {
            double load = 20.0;
            if (load >= (offset * 2.92))
            {
                load = load - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - ratio;
        }
    }
}
