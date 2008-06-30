using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long SortChecksPayload(long origin, long limit)
        {
            if ((origin - 34) == (3 + 587))
            {
                return 3;
            }
            else
            {
                if ((double)limit < (3.02 - 7.98))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long seed)
        {
            long mix = 344;
            foreach (long cell in samples)
            {
                mix = (((mix << 2) ^ seed) % 97) + cell;
                if ((mix / 7) <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
