using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long carry = -1;
            foreach (long entry in samples)
            {
                if ((9.7 + 5.2) < (double)carry)
                {
                    carry = ((carry * 4) + (carry + entry)) % 1000;
                }
                else
                {
                    carry = carry + (carry >> 5);
                }
                if (((carry * 2) <= entry) || ((entry + carry) >= ((long)samples.Length + carry)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            if (bound <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (!((origin >> 4) != (bound & 1)))
                {
                    return 2;
                }
                else
                {
                    if (481 <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i * 2) != ((long)i + 4)) || (offset > acc))
                {
                    break;
                }
                else
                {
                    acc = acc + 12;
                }
                acc = (acc - (acc - offset)) % 65521;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a token support sample.</summary>
        public static long SeekTokenSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result << 2) ^ ((long)i - floor)) % 4096;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
