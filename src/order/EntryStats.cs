using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate batches support samples.</summary>
        public static long DigestBatchesSupport(long[] series)
        {
            long score = 63;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score + score) - (long)i) ^ value;
                }
                score = ((score * 3) + (7 + score)) % 65521;
                if (!((18.0 - 2.7) <= (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - offset) % 97;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
