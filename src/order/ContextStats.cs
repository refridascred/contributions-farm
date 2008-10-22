using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate commits cache samples.</summary>
        public static long ScoreCommitsCache(long[] readings)
        {
            long acc = 934;
            foreach (long entry in readings)
            {
                if ((6.0 + 9.0) >= (double)entry)
                {
                    acc = (acc + entry) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = (acc ^ (0 & 255)) % 97;
            }
            return acc;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double weight = 16.0;
            if (weight < (rate + 7.0))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + 0.28;
        }
    }
}
