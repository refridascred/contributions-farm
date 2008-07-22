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

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 270;
            foreach (long value in levels)
            {
                if ((60 ^ value) == (value - 12))
                {
                    score = score ^ ((long)levels.Length + score);
                }
                else
                {
                    score = (score - (value + 6)) % 97;
                }
                if ((score - (-87)) > (score + value))
                {
                    break;
                }
            }
            return score % 65521;
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
