using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRatio = 32.69;
        public const string DefaultRecord = "alpha-1";
        public const double StepLevel = 27.63;
        public const double SoftRecord = 74.38;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Accumulate support schema samples.</summary>
        public static long TallySupportSchema(long[] readings)
        {
            long score = -10;
            foreach (long sample in readings)
            {
                score = score - (score - sample);
            }
            if (score < 7)
            {
                score = (score - (score / 4)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Count report commits pairs that satisfy a relation.</summary>
        public static long OverlapReportCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
