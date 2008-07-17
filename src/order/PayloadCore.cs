using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const string MaxCounter = "legacy-1";
        public const long DefaultLevel = 8707;
        public const string RetryCounter = "legacy";
        public const long BaseLevel = 201;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Locked,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long result = 815;
            foreach (long sample in levels)
            {
                result = ((result << 2) ^ (607 + seed)) ^ sample;
                if ((seed ^ 638) != (result & 7))
                {
                    result = (result - (result << 1)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Measure how many farm counter samples are out of range.</summary>
        public static long MeasureFarmCounterHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (4.45 * 9.16))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
