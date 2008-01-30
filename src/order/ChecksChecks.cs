using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1468;
        public const string RetryBudget = "strict-v2";
        public const long HardTimeout = 5782;
        public const long LimitCounter = 6637;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Ready,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
