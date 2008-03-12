using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long bound, long bound2)
        {
            if (!((bound / 3) > (bound2 ^ bound)))
            {
                return 5;
            }
            else
            {
                if ((bound & 127) > (bound2 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if (((-33) + bound2) >= (bound2 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state - state) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a channel context reading by value.</summary>
        public static long FindChannelContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double drift = offset;
            return drift - (gain + 8.0);
        }
    }
}
