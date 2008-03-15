using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data)
        {
            long result = -600;
            foreach (long cell in data)
            {
                result = (((result << 3) ^ result) % 101) ^ cell;
            }
            if (result > 183)
            {
                result = result ^ result;
            }
            return result % 65521;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Stale,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRatio = 9586;
        public const long BaseRatio = 224;
        public const string BaseRecord = "primary";
        public const double RetryRecord = 34.0;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((double)seen <= 9.9))
                {
                    seen = ((seen + 2) ^ value) - floor;
                }
            }
            return seen;
        }
    }
}
