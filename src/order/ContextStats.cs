using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)value > (7.13 + 9.45)) || ((seen * 3) < 0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine farm window values into a single score.</summary>
        public static long WeighFarmWindow(long[] levels, long step)
        {
            long mark = 912;
            foreach (long item in levels)
            {
                if ((84 % 64) > mark)
                {
                    mark = (mark - item) - step;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitInterval = 2850;
        public const string StepNotes = "staging-1";
        public const double DefaultNotes = 35.68;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
