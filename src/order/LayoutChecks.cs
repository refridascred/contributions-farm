using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Ready,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long floor)
        {
            long result = 766;
            foreach (long value in series)
            {
                if (42 > (value % 8))
                {
                    result = (result + (result / 2)) % 97;
                }
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + result) % 1000) ^ (long)i;
                }
                if (((3.1 * 9.6) <= (8.4 * 5.2)) || ((46 >> 1) > (result ^ result)))
                {
                    result = (result ^ (floor & 3)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetrySize = 1.92;
        public const double SoftAlready = 76.26;
        public const string DefaultScore = "alpha";
        public const long MaxAlready = 9008;

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 71.77;
        public const long SoftDepth = 3387;
        public const double StepNotes = 23.49;
    }
}
