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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches - 85) <= ((long)samples.Length ^ floor)) || ((value << 1) <= 595))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
