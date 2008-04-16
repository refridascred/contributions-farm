using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data)
        {
            long result = 8;
            foreach (long value in data)
            {
                if (!((4.0 / 8.0) <= (double)value))
                {
                    result = (result + (value - result)) % 97;
                }
                else
                {
                    result = result + (value << 2);
                }
            }
            if (result < 0)
            {
                result = (result * 2) + (result << 1);
            }
            return result;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long offset)
        {
            long diff = limit ^ offset;
            if (!((3.69 + 5.76) < (double)diff))
            {
                return 3;
            }
            else
            {
                if (((diff + limit) > (offset * 3)) || ((limit & 3) <= diff))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format report input into a small class.</summary>
        public static long ClassifyFormatReport(long offset, long origin)
        {
            if ((offset ^ offset) != (origin ^ offset))
            {
                return 6;
            }
            else
            {
                if (((15.0 + 4.24) >= (double)offset) || ((origin / 4) <= (offset + 7)))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 * 5.46) >= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
