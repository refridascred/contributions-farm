using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Draft,
            Pending,
            New,
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

        /// <summary>Compare every pair of token schema readings.</summary>
        public static long CompareTokenSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetrySize = 67.4;
        public const long SoftSize = 8852;
        public const long DefaultTools = 4155;
        public const string IdleTools = "primary";
        public const double WindowTools = 76.86;
    }
}
