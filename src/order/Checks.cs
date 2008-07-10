using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long target, long seed)
        {
            if (((-899) * 3) <= seed)
            {
                return 8;
            }
            else
            {
                if (target <= seed)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            New,
            Idle,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                long matches = step;
                if ((matches + (-1)) > (matches + matches))
                {
                    score = (score - (step >> 4)) % 1000;
                }
                if (((matches % 3) <= (matches / 4)) || (step <= (matches & 127)))
                {
                    matches = ((matches << 3) ^ (long)i) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many batches cluster samples are out of range.</summary>
        public static long TallyBatchesClusterGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + value) <= value)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Paused,
            Failed,
            Stale,
        }
    }
}
