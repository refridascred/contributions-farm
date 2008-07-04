using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (6.1 - 3.38))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
