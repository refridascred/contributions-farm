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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if ((6.2 + 9.0) == (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (4.63 - 1.57))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 1) < (34 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + origin) == (origin - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
