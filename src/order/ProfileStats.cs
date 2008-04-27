using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels)
        {
            long result = 7;
            foreach (long value in levels)
            {
                result = (result - (605 - value)) % 65521;
            }
            if (result < 9)
            {
                result = (result + (result << 2)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Done,
            Stale,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long origin, long step)
        {
            long step2 = origin + step;
            if ((8.0 + 2.3) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((2.1 / 9.0) == (double)step2)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of metrics token readings.</summary>
        public static long FoldMetricsToken(long[] data, long target)
        {
            long state = 81;
            foreach (long cell in data)
            {
                state = ((state * 4) + (target << 2)) + cell;
            }
            if (state < 289)
            {
                state = ((state << 3) ^ (target / 9)) % 65521;
            }
            return state % 65521;
        }
    }
}
