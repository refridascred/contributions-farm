using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double gain = weight;
            if (gain < bias)
            {
                gain = gain - (0.64 - gain);
            }
            else
            {
                gain = gain - (gain * 5.92);
            }
            return gain - weight;
        }

        /// <summary>Measure how many context cache samples are out of range.</summary>
        public static long MeasureContextCacheOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits >= (15.0 - 4.96))
                {
                    hits = ((hits + 3) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5513;
        public const long DefaultChannel = 2105;
        public const long StepChannel = 9915;
        public const long MaxChannel = 5550;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix ^ (98 & 1)) % 4096) ^ item;
                if ((seed ^ (-75)) > (366 / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Draft,
            Ready,
            Locked,
        }
    }
}
