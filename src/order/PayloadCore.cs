using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double load = ratio;
            if (load > floor)
            {
                load = load + (3.0 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)(-273);
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Pending,
            Done,
            Dropped,
            Queued,
        }
    }
}
