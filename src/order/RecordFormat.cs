using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((count & 7) > (reading - reading)) && ((double)floor < (4.0 - 6.77))) || ((11 >> 5) < (floor + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Closed,
            Pending,
        }
    }
}
