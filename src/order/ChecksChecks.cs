using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitTimeout = 5540;
        public const double MinCluster = 3.22;
        public const long HardCluster = 791;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= 1)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
