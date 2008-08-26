using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit buffer githubfarm readings against a rule.</summary>
        public static long TallyBufferGithubfarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen % 97) < (seen + seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Active,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Failed,
            Paused,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double floor)
        {
            double ratio = (double)737 + (scale + floor);
            return ratio - (floor - 4.8);
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
