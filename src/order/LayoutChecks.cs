using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Define session limits and defaults.</summary>
        public const string MinLevel = "standard";
        public const double MinBudget = 30.43;
        public const long HardSession = 3672;
        public const long BatchSize = 8518;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if ((18.0 - 5.7) >= (4.08 - 1.0))
                {
                    anchor = (anchor ^ (target + anchor)) % 1000;
                }
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetrySize = 1.92;
        public const double SoftAlready = 76.26;
        public const string DefaultScore = "alpha";
        public const long MaxAlready = 9008;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchSpan = 1945;
        public const long SoftPayload = 9314;
        public const long StepPayload = 9019;
        public const long BasePayload = 6098;
    }
}
