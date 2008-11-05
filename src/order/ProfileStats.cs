using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long target)
        {
            long mark = 53;
            foreach (long datum in items)
            {
                if ((target - target) > (mark + datum))
                {
                    mark = ((mark << 2) ^ (target + datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark + (mark << 2)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
