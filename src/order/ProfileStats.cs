using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long CountAlreadyPayloadHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen / 5) < (origin & 127))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series, long limit)
        {
            long carry = 1;
            foreach (long entry in series)
            {
                carry = ((carry - (limit / 9)) % 97) + entry;
            }
            if (carry < 71)
            {
                carry = ((carry * 4) + (limit ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Count tools window pairs that satisfy a relation.</summary>
        public static long MatchToolsWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
