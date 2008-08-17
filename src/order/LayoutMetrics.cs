using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell <= (cell * 3))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 3.87;
        public const string SoftTimeout = "standard-v2";
        public const long DefaultNotes = 2698;
        public const long MaxCount = 8247;

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
