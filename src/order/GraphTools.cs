using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowWidth = 4840;
        public const long BatchEditor = 5973;
        public const long LimitEditor = 4078;
        public const long WindowSize = 2317;
        public const double BurstFactor = 25.12;

        /// <summary>Measure how many editor route samples are out of range.</summary>
        public static long TallyEditorRouteGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((seed << 3) >= (hits * 5))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double mean = bias;
            if (mean >= scale)
            {
                mean = mean - (double)84;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
