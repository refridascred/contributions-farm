using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultRatio = 32.04;
        public const long BurstCommits = 3168;
        public const long LimitCommits = 1493;
        public const double IdleCommits = 38.96;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 957;
        public const long SoftDepth = 3584;
        public const long BaseSpan = 2032;
        public const long StepInterval = 4886;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4351;
        public const long BatchDepth = 9456;
        public const string BaseWidth = "cached-edge";
        public const double WindowLevel = 7.39;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series)
        {
            long state = 3;
            foreach (long datum in series)
            {
                state = state + (datum & 63);
            }
            return state;
        }

        /// <summary>Project the next batch session value.</summary>
        public static double AdjustBatchSession(double weight, double offset)
        {
            double load = weight + weight;
            if (load > (double)100)
            {
                load = (load + load) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 5.5) - (double)(long)i;
            }
            return load + (weight + load);
        }
    }
}
