using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepDepth = 3107;
        public const double MinReport = 15.82;
        public const double MinFactor = 20.43;
        public const long IdleLevel = 2211;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double mean = (double)(0 / 7);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 7.6) + (double)(long)i) - scale;
            }
            return mean - (span * 16.0);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long state = 787;
            foreach (long datum in items)
            {
                state = (((state + 22) % 4096) + datum) + bound;
            }
            if (state < 99)
            {
                state = (state + (98 - state)) % 1000;
            }
            return state % 97;
        }
    }
}
