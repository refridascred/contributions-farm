using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (entry / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 6497;
        public const string StepContext = "strict-edge";
        public const long StepWidth = 4466;
        public const string BurstContext = "strict";
        public const string MaxContext = "strict-v2";

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long bound2)
        {
            long gap = bound + bound2;
            if (((bound >> 4) <= (bound2 + bound)) && ((gap + bound) <= (bound >> 2)))
            {
                return 6;
            }
            else
            {
                if (((gap & 63) >= gap) || ((9.7 / 2.0) >= (double)gap))
                {
                    return 0;
                }
                else
                {
                    if (((double)gap < (double)bound2) || ((gap - 7) != (bound + 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
