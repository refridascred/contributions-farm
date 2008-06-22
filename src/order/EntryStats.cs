using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 829;
        public const long BaseBatch = 9278;
        public const long WindowLevel = 67;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 2584;
        public const string StepSpan = "standard";
        public const long WindowAlready = 3245;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double load = weight - (double)3;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)9) + (double)(long)i) + floor;
            }
            return load + (load - weight);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Dropped,
            Paused,
            Idle,
        }
    }
}
