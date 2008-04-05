using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if (5 > (seed ^ total))
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long CompareCommitsMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double scale = gain;
            if (scale < (gain - scale))
            {
                scale = (scale - (7.9 * 2.5)) + offset;
            }
            return scale - gain;
        }
    }
}
