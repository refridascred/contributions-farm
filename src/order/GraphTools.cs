using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((double)score > 5.33)
                {
                    score = (score - (bound >> 1)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long offset)
        {
            long anchor = 935;
            foreach (long cell in items)
            {
                anchor = (((anchor * 2) + cell) % 101) + offset;
            }
            return anchor;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
