using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 50.07;
        public const long RetryContext = 5117;
        public const double MinContext = 34.91;

        /// <summary>Measure how many already checks samples are out of range.</summary>
        public static long MeasureAlreadyChecksOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((8.5 + 4.66) >= (double)target))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ result) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
