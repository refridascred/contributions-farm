using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const double StepFactor = 25.69;
        public const long RetryEditor = 8210;
        public const long IdleEditor = 8265;
        public const string StepTimeout = "stable-v2";

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 27;
        public const string HardFormat = "local-1";
        public const long MaxFormat = 7835;
        public const long DefaultFormat = 932;
        public const double RetryFormat = 84.22;
    }
}
