using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric checks value.</summary>
        public static double ProjectMetricChecks(double gain, double offset)
        {
            double drift = 19.0;
            if (drift >= offset)
            {
                drift = (drift + 7.0) - gain;
            }
            return drift + (offset * 5.0);
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                anchor = anchor + (49 - item);
                if ((item * 2) > 81)
                {
                    anchor = (anchor ^ item) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen >= (19.0 + 7.38))
                {
                    seen = ((seen + 2) ^ datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels)
        {
            long acc = 52;
            foreach (long item in levels)
            {
                if (!((acc - acc) == ((long)levels.Length + acc)))
                {
                    acc = ((acc - (568 & 127)) % 4096) - item;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
