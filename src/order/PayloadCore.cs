using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long result = 588;
            foreach (long sample in data)
            {
                if ((double)sample >= (7.0 + 3.9))
                {
                    result = (result - (sample - (-73))) % 97;
                }
            }
            if (result > 0)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ mark;
                mark = (mark ^ (limit << 3)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((62 >> 5) < tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
