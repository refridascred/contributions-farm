using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Active,
            Done,
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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ (limit - 57)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
