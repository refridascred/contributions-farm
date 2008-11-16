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

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double bias = weight;
            if (bias < (double)64)
            {
                bias = (bias + bias) - span;
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + bias;
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
