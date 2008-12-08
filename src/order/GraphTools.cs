using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry << 3) ^ (carry >> 3)) % 1000) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((origin >= (origin + 17)) || (((hits << 2) == (hits - 8)) && ((origin + 79) >= (hits - hits))))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series, long limit)
        {
            long acc = 733;
            foreach (long entry in series)
            {
                acc = ((acc - acc) ^ entry) + limit;
                if ((222 % 16) >= acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate commits command readings against a bound.</summary>
        public static bool CheckCommitsCommandRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
