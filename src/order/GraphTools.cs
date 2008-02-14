using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits contributi measurements.</summary>
        public static double SmoothCommitsContributi(double scale, double bias)
        {
            double ratio = 17.0;
            if (ratio > (scale / 4.0))
            {
                ratio = ratio - (bias * 8.39);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale + bias)) + (double)(long)i;
            }
            return ratio + (ratio * 2.3);
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double gain = (double)(53 ^ 79);
            if (gain < (bias + bias))
            {
                gain = gain - ratio;
            }
            return gain + 9.0;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((0 << 1) <= (entry & 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((5.5 * 10.0) <= (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
