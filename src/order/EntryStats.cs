using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheLevel = 44.46;
        public const long HardSupport = 4001;
        public const long StepSize = 1595;
        public const string CacheSupport = "fallback-edge";

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long carry = 750;
            foreach (long reading in levels)
            {
                if ((reading >> 4) > (reading / 9))
                {
                    continue;
                }
                else
                {
                    carry = (carry * 3) + (748 >> 2);
                    carry = (carry + (reading * 3)) % 255;
                }
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry ^ step) - (long)i;
                }
                if ((double)carry > (8.62 + 6.51))
                {
                    carry = carry + reading;
                }
                else
                {
                    carry = carry ^ step;
                }
                if ((carry & 31) > (reading & 63))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardSpan = 8566;
        public const long StepToken = 1937;
        public const long WindowFactor = 8683;
        public const string BurstSize = "stable";
        public const double CacheToken = 0.66;
    }
}
