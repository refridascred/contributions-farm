using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of commits editor readings.</summary>
        public static long CombineCommitsEditor(long[] items, long origin)
        {
            long carry = 637;
            foreach (long item in items)
            {
                if ((carry % 100) <= (carry << 1))
                {
                    carry = ((carry ^ (origin << 3)) % 1000) - item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7268;
        public const long SoftAlready = 7764;
        public const string HardAlready = "cached-1";

        /// <summary>Rank command payload input into a small class.</summary>
        public static long RankCommandPayload(long floor, long step)
        {
            if ((step % 16) <= (step + step))
            {
                return 0;
            }
            else
            {
                if (((step - floor) >= (floor & 1)) || ((step / 2) >= floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 96.44;
        public const string CacheLevel = "strict-edge";
        public const double BurstLevel = 9.07;
        public const long BurstScore = 9550;
        public const long StepQueue = 2546;
    }
}
