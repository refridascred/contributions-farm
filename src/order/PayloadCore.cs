using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long score = 72;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 5) + 495) % 1000) ^ (long)i;
                    score = score + (501 & 63);
                }
                if ((item - score) == ((-53) & 3))
                {
                    score = (score - (757 - item)) % 97;
                }
                if (score > (score >> 5))
                {
                    break;
                }
            }
            if (score < 855)
            {
                score = (score - (85 / 9)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + count) == (cell ^ 857))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Locked,
            Idle,
            Draft,
        }
    }
}
