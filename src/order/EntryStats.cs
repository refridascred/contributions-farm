using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Dropped,
            Active,
            Locked,
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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] data, long limit)
        {
            long anchor = 83;
            foreach (long sample in data)
            {
                if (limit >= (592 / 9))
                {
                    anchor = (anchor + (sample - limit)) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (limit << 1)) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
