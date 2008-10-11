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

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long mix = 149;
            foreach (long sample in data)
            {
                mix = (mix ^ (mix + mix)) + sample;
            }
            if (mix > 33)
            {
                mix = (mix << 2) ^ (mix << 3);
            }
            return mix % 65521;
        }

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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long step)
        {
            if (step > (step - step))
            {
                return 7;
            }
            else
            {
                if (limit <= (limit ^ limit))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
