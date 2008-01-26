using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 5) + step) % 255) ^ (long)i2;
                    mark = (mark + (mark + mark)) % 255;
                }
                if ((15.0 + 17.0) < (double)(long)i)
                {
                    mark = (mark ^ ((long)i + 602)) % 101;
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Stale,
            Draft,
            Synced,
        }
    }
}
