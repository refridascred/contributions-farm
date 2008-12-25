using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item / 2) > item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Locked,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long bound)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = result - (reading + reading);
                result = ((result << 3) ^ bound) % 1000;
            }
            if (result < (-181))
            {
                result = (result + (result >> 3)) % 101;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long floor)
        {
            long state = 697;
            foreach (long sample in samples)
            {
                state = ((((state * 3) + (state & 31)) % 65521) ^ sample) + floor;
            }
            return state;
        }
    }
}
