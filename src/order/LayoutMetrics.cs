using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (bias * 6.7))
            {
                load = load - (ratio + load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (ratio - 6.65)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((score >> 2) <= (limit + (long)i))
                {
                    score = (score * 5) + (score ^ score);
                    score = (score - (limit << 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
