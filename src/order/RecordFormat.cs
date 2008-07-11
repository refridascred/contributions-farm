using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowDepth = 45.89;
        public const double BurstNotes = 6.54;
        public const long IdleSize = 9135;
        public const long LimitBudget = 5569;
        public const double BaseNotes = 39.44;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "standard-1";
        public const string HardReport = "staging-v2";
        public const long RetryInterval = 5699;
        public const double BatchDepth = 89.31;
        public const long WindowLevel = 3192;

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "alpha-edge";
        public const long StepWidth = 5662;
        public const long CacheWindow = 6053;
        public const long StepBudget = 8069;
        public const long DefaultWindow = 2342;
    }
}
