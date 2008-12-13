using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long step2)
        {
            if (!(((-6) * 3) < (step2 - 283)))
            {
                return 8;
            }
            else
            {
                if (((step << 1) < (7 & 3)) && (1.6 < (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((step2 + step2) <= (step2 % 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long TallyProfileNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) > (cell + 855))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Ready,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Audit editor already readings against a rule.</summary>
        public static long TallyEditorAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits == (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }
    }
}
