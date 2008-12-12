using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((487 * 2) > datum)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowTimeout = "staging";
        public const long DefaultQueue = 4657;
        public const long LimitQueue = 1903;
        public const double CacheQueue = 30.74;

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 39;
            foreach (long item in levels)
            {
                state = (state + state) % 65521;
                if ((state + state) > (item << 3))
                {
                    state = state + (item + item);
                }
            }
            return state;
        }
    }
}
