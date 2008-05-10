using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item <= (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double scale = (double)(7 % 5);
            if (scale >= (7.41 - 11.0))
            {
                scale = (scale + (scale / 8.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool CheckContextPayloadBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin <= 13.0)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
