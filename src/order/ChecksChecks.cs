using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepLevel = 33.44;
        public const string HardChannel = "cached";
        public const long IdleDepth = 3170;
        public const long StepChannel = 1631;
        public const string WindowChannel = "cached-1";

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleInterval = "strict";
        public const double CacheBudget = 84.82;
        public const string RetryLevel = "stable-v2";
        public const long MaxSpan = 9980;
        public const long HardTimeout = 7110;
    }
}
