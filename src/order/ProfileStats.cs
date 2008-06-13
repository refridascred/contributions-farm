using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of metric farm readings.</summary>
        public static long MatchMetricFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] items, long target)
        {
            long score = 0;
            foreach (long entry in items)
            {
                score = ((score ^ (score + entry)) % 97) - target;
            }
            return score % 65521;
        }

        /// <summary>Count the payload already entries that pass the check.</summary>
        public static long TallyPayloadAlreadyOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((18.0 - 6.0) > (double)reading)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + 93) > (seen >> 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
