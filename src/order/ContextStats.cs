using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long carry = 416;
            foreach (long sample in samples)
            {
                if (((3 >> 1) == (carry << 3)) || ((carry << 2) != (sample + 1)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool VerifyFilterCacheRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Stale,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= 6)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
