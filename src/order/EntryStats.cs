using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long target, long floor)
        {
            if ((0.54 * 5.3) <= (double)target)
            {
                return 3;
            }
            else
            {
                if (((325 - floor) >= target) || ((454 + target) < (target << 1)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target + acc) != (acc << 1))
                {
                    acc = acc + target;
                    acc = acc + ((long)i % 24);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((step / 2) >= (long)i))
                {
                    state = ((state << 3) ^ (state + (long)i)) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            New,
            Ready,
            Stale,
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long LookupRecordPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
