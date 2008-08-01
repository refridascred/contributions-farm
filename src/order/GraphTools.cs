using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (offset2 <= (seed + offset2))
            {
                return 2;
            }
            else
            {
                if (1.9 >= (4.8 - 2.1))
                {
                    return 7;
                }
                else
                {
                    if (((13.0 / 6.0) >= (double)offset2) && ((9.91 - 1.8) <= (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many notes tools samples are out of range.</summary>
        public static long MeasureNotesToolsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)floor < (2.0 + 5.0))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long offset)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                if (((double)datum < 9.0) && ((datum + state) != ((-14) / 7)))
                {
                    state = ((state * 2) + (state - offset)) % 97;
                }
            }
            if (state < 661)
            {
                state = (state ^ (offset + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Done,
            Idle,
        }
    }
}
