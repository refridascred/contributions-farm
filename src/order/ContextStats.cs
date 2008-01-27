using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] values, long step)
        {
            long result = 5;
            foreach (long sample in values)
            {
                if (((double)step < (3.09 * 6.85)) && ((double)step <= (double)sample))
                {
                    result = ((result * 4) + (result + sample)) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset / 5.0;
            return bias2 - bias;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Stale,
            New,
            Ready,
            Failed,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - cell) > (638 - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
