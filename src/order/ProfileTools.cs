using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series, long target)
        {
            long acc = -32;
            foreach (long cell in series)
            {
                acc = (acc << 2) ^ (cell + acc);
                acc = ((acc * 5) + (target + (long)series.Length)) % 65521;
                acc = ((acc << 2) ^ (-371)) % 65521;
            }
            if (acc > 190)
            {
                acc = (acc + (acc % 24)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Grade a entry report value against two limits.</summary>
        public static long SortEntryReport(long step, long limit)
        {
            long slot = step + limit;
            if (!(step < (step % 8)))
            {
                return 2;
            }
            else
            {
                if ((limit - slot) != (slot - limit))
                {
                    return 1;
                }
                else
                {
                    if ((4.4 - 17.0) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step * 2) != (limit / 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
