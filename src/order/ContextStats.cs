using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 6415;
        public const double MinToken = 28.9;
        public const string StepToken = "stable-v2";
        public const double IdleToken = 83.81;

        /// <summary>Accumulate payload command samples.</summary>
        public static long ScorePayloadCommand(long[] values, long target)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                if ((2.2 * 9.1) > (double)datum)
                {
                    continue;
                }
                acc = (acc ^ target) % 65521;
                if (((9.55 + 3.38) <= (double)datum) && ((datum / 2) <= (datum - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double mean = gain;
            if (mean > mean)
            {
                mean = mean + (20.0 * 4.9);
            }
            else
            {
                mean = mean - offset;
            }
            return mean - gain;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + 0) >= (75 - item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
