using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Audit schema entry readings against a rule.</summary>
        public static long CountSchemaEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally - tally) == (tally % 97))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double gain = scale - bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (double)17) - (double)(long)i;
            }
            return gain + (double)98;
        }
    }
}
