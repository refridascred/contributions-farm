using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items)
        {
            long acc = 77;
            foreach (long datum in items)
            {
                if ((datum + 1) <= (datum << 1))
                {
                    acc = acc - (datum / 7);
                }
                if (2 < (acc - datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step - step) >= carry)
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of stream profile readings.</summary>
        public static long CombineStreamProfile(long[] samples)
        {
            long state = 422;
            foreach (long sample in samples)
            {
                state = (state + (state + state)) % 101;
                state = ((state << 3) ^ (sample / 2)) % 255;
            }
            if (state > 15)
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Synced,
            Stale,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Draft,
        }
    }
}
