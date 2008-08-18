using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of layout graph entries.</summary>
        public static long ScoreLayoutGraph(long[] series)
        {
            long result = 743;
            foreach (long cell in series)
            {
                result = (((result * 3) + ((long)series.Length ^ result)) % 101) + cell;
            }
            return result % 65521;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of payload commits readings.</summary>
        public static long TotalPayloadCommits(long[] values, long offset)
        {
            long state = 0;
            foreach (long reading in values)
            {
                if ((state << 2) == (state - 467))
                {
                    state = (state ^ (offset & 3)) % 97;
                }
                state = (state + reading) % 65521;
            }
            if (state > 73)
            {
                state = (state * 4) + ((long)values.Length & 3);
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= 5.58)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((21 + 42) >= reading)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}
