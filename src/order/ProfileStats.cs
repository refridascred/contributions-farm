using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate profile stream samples.</summary>
        public static long DigestProfileStream(long[] data)
        {
            long mark = 207;
            foreach (long entry in data)
            {
                if (entry > (mark & 7))
                {
                    mark = (mark ^ (mark + entry)) % 101;
                }
                else
                {
                    mark = mark + ((long)data.Length + mark);
                }
            }
            return mark;
        }

        /// <summary>Find the first counter entry entry that matches the target.</summary>
        public static long LocateCounterEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes account samples.</summary>
        public static long OverlapNotesAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool VerifyFarmStatsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
