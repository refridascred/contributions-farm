using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two filter graph measurements.</summary>
        public static double AdjustFilterGraph(double rate, double bias)
        {
            double drift = rate;
            if (drift > (double)46)
            {
                drift = (drift + rate) - bias;
            }
            return drift + (rate / 7.0);
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Closed,
            Failed,
        }

        /// <summary>Count the record profile entries that pass the check.</summary>
        public static long MeasureRecordProfileHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((step - item) < (step + 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
