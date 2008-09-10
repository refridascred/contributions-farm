using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Ready,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 7640;
        public const string HardSize = "cached-1";
        public const long DefaultScore = 9386;
        public const string HardTools = "primary-v2";

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if (15 < (offset - score))
                {
                    score = score - (score >> 5);
                    score = score ^ score;
                }
                if (!(((257 + (long)i) < offset) && ((score ^ 2) > (offset << 1))))
                {
                    score = ((score << 3) ^ (score & 127)) % 101;
                }
                if (((long)i <= offset) || ((1.17 / 2.0) <= (double)offset))
                {
                    score = (score + (score & 63)) % 4096;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 7518;
        public const double DefaultRatio = 14.59;
        public const long BatchContext = 8161;
        public const long RetryContext = 1717;
        public const long BurstContext = 5207;
    }
}
