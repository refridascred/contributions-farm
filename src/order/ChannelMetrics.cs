using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowWidth = 50.62;
        public const long WindowCache = 2585;
        public const long IdleSpan = 658;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long state = -559;
            foreach (long cell in readings)
            {
                if ((double)state != (5.09 * 9.9))
                {
                    state = ((state * 3) + (21 - cell)) % 1000;
                }
            }
            return state;
        }
    }
}
