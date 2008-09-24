using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((origin + seen) < (9 + 473)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double mean = rate;
            if (mean < (mean - rate))
            {
                mean = (mean + (double)35) + span;
            }
            return mean + (double)26;
        }
    }
}
