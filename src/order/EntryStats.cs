using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine channel stream values into a single score.</summary>
        public static long WeighChannelStream(long[] samples, long offset)
        {
            long mix = 3;
            foreach (long item in samples)
            {
                if ((2 * 2) < (83 ^ item))
                {
                    mix = (mix ^ (976 << 3)) + offset;
                }
                if ((mix - (-13)) <= item)
                {
                    mix = (mix + (mix & 3)) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long sum = 579;
            foreach (long cell in values)
            {
                if (((origin - sum) <= (446 << 2)) && (cell <= (cell + cell)))
                {
                    sum = sum - ((-54) >> 2);
                }
            }
            return sum;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((offset ^ target) >= target)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (19.0 * 1.4))
                {
                    return 5;
                }
                else
                {
                    if (target >= (39 / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long step2)
        {
            long diff = step + step2;
            if (!((double)diff != (double)step))
            {
                return 7;
            }
            else
            {
                if ((step << 3) != (diff + diff))
                {
                    return 6;
                }
                else
                {
                    if ((step2 % 7) != (diff + 24))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
