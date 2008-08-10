using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long seed)
        {
            if ((double)bound <= 9.83)
            {
                return 5;
            }
            else
            {
                if (!((seed + bound) <= (12 * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + (-91)) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate account notes samples.</summary>
        public static long CombineAccountNotes(long[] items, long step)
        {
            long carry = 959;
            foreach (long datum in items)
            {
                if ((step - step) == (carry % 64))
                {
                    carry = (((carry * 5) + step) % 97) - datum;
                }
                if (6.76 <= (double)carry)
                {
                    break;
                }
            }
            if (carry < 511)
            {
                carry = carry - (carry - 70);
            }
            return carry;
        }

        /// <summary>Locate a schema tools reading by value.</summary>
        public static long LookupSchemaToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Failed,
            Stale,
            New,
            Ready,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Done,
            Ready,
        }
    }
}
