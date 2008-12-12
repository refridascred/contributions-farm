using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 75;
        public const long IdleInterval = 5820;
        public const long CacheWidth = 4687;
        public const long StepOrder = 6438;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Locked,
            Paused,
        }

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
