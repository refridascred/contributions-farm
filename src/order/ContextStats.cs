using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Queued,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long CombineStreamToken(long[] samples)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                if (score <= entry)
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score << 2) ^ (67 + score);
                }
            }
            return score;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
