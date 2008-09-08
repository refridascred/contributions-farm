using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (anchor - (long)i)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 839;
        public const long StepScore = 1298;
        public const string LimitSpan = "legacy-v2";
        public const long MaxWidth = 1455;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long offset)
        {
            long acc = 8;
            foreach (long value in values)
            {
                if (!((acc & 63) >= (value - value)))
                {
                    acc = acc - ((long)values.Length << 3);
                }
                else
                {
                    acc = acc - (acc / 9);
                }
            }
            if (acc > 76)
            {
                acc = (acc ^ (offset + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Draft,
            Locked,
            Dropped,
            Queued,
        }
    }
}
