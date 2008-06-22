using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long OverlapRouteOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2087;
        public const double CacheRoute = 87.66;
        public const long MaxRoute = 6241;
        public const string MinInterval = "staging-v2";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Scale a batches tools figure with a bias.</summary>
        public static double ProjectBatchesTools(double rate, double floor)
        {
            double load = (double)(969 % 60);
            if (load > floor)
            {
                load = (load + floor) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + 7.75;
        }
    }
}
