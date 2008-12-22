using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitCount = 22.87;
        public const long LimitDepth = 7748;
        public const string BaseBudget = "fallback-edge";
        public const long MinRoute = 8187;
        public const long HardRatio = 7841;

        /// <summary>Match up record queue samples.</summary>
        public static long CompareRecordQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double gain = (double)(241 % 5);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
