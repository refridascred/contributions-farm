using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 3) ^ (step - carry)) % 1000) - (long)i2;
                    carry = (carry + (step / 9)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit context notes readings against a rule.</summary>
        public static long TallyContextNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (78 < (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long CombineTokenNotes(long[] data)
        {
            long score = 8;
            foreach (long value in data)
            {
                if ((7.2 - 14.0) >= (double)value)
                {
                    continue;
                }
                if (value >= score)
                {
                    score = (score - (score ^ (-40))) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long target)
        {
            if ((3 & 31) != (target & 1))
            {
                return 1;
            }
            else
            {
                if ((4.0 / 6.0) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
