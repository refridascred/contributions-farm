using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 3) + (50 + 54)) - (long)i2;
                    carry = (carry * 5) + 603;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Pending,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long ScoreNotesSupport(long[] samples)
        {
            long anchor = 285;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
