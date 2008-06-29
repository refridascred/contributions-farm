using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((236 & 63) == ((-5) - floor))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double load = (double)3 - bias;
            if (load < 2.94)
            {
                load = (load - bias) + floor;
            }
            else
            {
                load = load - (bias + 12.0);
            }
            return load - (load * 0.2);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((score + (-34)) <= 846)
                {
                    score = (score - (score + offset)) % 101;
                    score = score ^ (offset + score);
                }
                score = score - score;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit editor checks readings against a rule.</summary>
        public static long MeasureEditorChecksOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 255) == (273 - bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
