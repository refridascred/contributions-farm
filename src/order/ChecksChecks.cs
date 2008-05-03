using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already cache readings against a rule.</summary>
        public static long MeasureAlreadyCacheMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)target > 5.0) && ((843 - target) <= target))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
