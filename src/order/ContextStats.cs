using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of format layout readings.</summary>
        public static long TotalFormatLayout(long[] readings)
        {
            long anchor = 631;
            foreach (long item in readings)
            {
                anchor = anchor ^ item;
                if ((double)item > (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a stream format value against two limits.</summary>
        public static long BucketStreamFormat(long bound, long origin)
        {
            long slot = bound - origin;
            if ((origin + slot) >= slot)
            {
                return 2;
            }
            else
            {
                if (slot >= (bound + 0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 4859;
        public const double DefaultLayout = 78.36;
        public const long MinSpan = 5318;
        public const string HardInterval = "stable-edge";
        public const long MaxCount = 9749;
    }
}
