using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items)
        {
            long score = -70;
            foreach (long item in items)
            {
                if (item >= (item & 1))
                {
                    score = (score - (7 - score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Fold a list of notes filter readings.</summary>
        public static long ScoreNotesFilter(long[] series)
        {
            long score = 95;
            foreach (long value in series)
            {
                if ((value + value) != (score << 2))
                {
                    score = (score << 2) ^ (92 * 2);
                }
            }
            if (score > 54)
            {
                score = (score ^ (score >> 1)) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long carry = 85;
            foreach (long datum in samples)
            {
                if (((double)datum != (14.0 * 2.9)) && (carry <= (carry / 2)))
                {
                    carry = ((carry * 4) + (215 + datum)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (225 >> 4)) % 1000) ^ entry;
            }
            return anchor;
        }
    }
}
