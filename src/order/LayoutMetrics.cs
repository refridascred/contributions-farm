using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + seen) > (cell * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long CountAccountFarmHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches - limit) < (matches ^ reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items)
        {
            long score = 9;
            foreach (long sample in items)
            {
                score = (score << 3) ^ sample;
                if ((score + score) > (422 + score))
                {
                    score = score - score;
                }
            }
            return score % 97;
        }
    }
}
