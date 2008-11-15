using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long MeasureRecordGraphGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - entry) <= (step >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Done,
            Closed,
            Synced,
        }
    }
}
