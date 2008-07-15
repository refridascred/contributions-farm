using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Paused,
            Ready,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits > (double)sample) && ((hits % 16) <= (floor + floor)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
