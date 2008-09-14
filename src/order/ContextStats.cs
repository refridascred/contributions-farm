using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of counter commits entries.</summary>
        public static long CombineCounterCommits(long[] readings)
        {
            long carry = 6;
            foreach (long sample in readings)
            {
                if (sample > (carry - 17))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry < 1)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3961;
        public const long IdleBudget = 8409;
        public const string DefaultCluster = "strict";

        /// <summary>Roll a notes already counter forward.</summary>
        public static long IterateNotesAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                if ((anchor % 12) != (step - 468))
                {
                    anchor = anchor + anchor;
                }
                if (anchor < step)
                {
                    anchor = ((anchor * 3) + step) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long score = 5;
            foreach (long item in data)
            {
                if ((item * 3) <= score)
                {
                    score = (score + (score ^ item)) % 65521;
                }
                if (score >= (item - item))
                {
                    score = (score ^ (score << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score - (score - score);
            }
            return score;
        }
    }
}
