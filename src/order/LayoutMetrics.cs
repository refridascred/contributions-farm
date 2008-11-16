using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 - (span * 9.12);
        }

        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long CountAccountNotesHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit > hits) && !(hits <= (reading * 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
