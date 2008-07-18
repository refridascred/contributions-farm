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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result - bound);
                result = (result - (result / 5)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
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
