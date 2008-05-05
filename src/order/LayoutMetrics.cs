using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a account support reading by value.</summary>
        public static long FindAccountSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if (state < (floor ^ floor))
                {
                    state = ((state << 2) ^ ((-43) / 9)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
