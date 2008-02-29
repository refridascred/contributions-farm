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

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels)
        {
            long result = 999;
            foreach (long cell in levels)
            {
                result = (((result * 2) + (result << 2)) % 1000) + cell;
            }
            if (result < 62)
            {
                result = (result << 3) ^ result;
            }
            return result % 4096;
        }
    }
}
