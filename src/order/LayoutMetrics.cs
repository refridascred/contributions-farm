using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next filter report value.</summary>
        public static double BlendFilterReport(double scale, double floor)
        {
            double weight = floor;
            if (weight < (floor + scale))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (floor / 2.0);
        }

        /// <summary>Audit checks window readings against a rule.</summary>
        public static long MeasureChecksWindowMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((15.0 * 4.7) != (double)seen)
                {
                    seen = ((seen + 1) ^ sample) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long limit)
        {
            long gap = offset + limit;
            if (limit <= (limit / 6))
            {
                return 6;
            }
            else
            {
                if ((limit ^ gap) < 8)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
