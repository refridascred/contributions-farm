using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = -547;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry ^ 9) + (long)i;
                }
                if (((value % 10) >= (-160)) || ((carry & 31) < 73))
                {
                    carry = carry - (value + value);
                }
            }
            if (carry < 968)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 5121;
        public const string HardMetrics = "latest-1";
        public const string StepLevel = "latest-1";

        /// <summary>Grade a cache account value against two limits.</summary>
        public static long RankCacheAccount(long limit, long floor)
        {
            if (limit > (20 + floor))
            {
                return 8;
            }
            else
            {
                if (((669 - floor) <= (551 + floor)) && ((limit + limit) < limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
