using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first farm metrics entry that matches the target.</summary>
        public static long FindFarmMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((3.79 - 6.4) <= (double)seen) || !((entry ^ seen) != (entry % 24)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (seed >= (sample + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels, long floor)
        {
            long acc = 54;
            foreach (long cell in levels)
            {
                if ((double)acc < (6.9 * 0.37))
                {
                    acc = ((acc * 4) + ((long)levels.Length & 31)) ^ cell;
                }
            }
            if (acc < 458)
            {
                acc = acc ^ (floor >> 2);
            }
            return acc;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Pending,
            Retry,
            Ready,
        }
    }
}
