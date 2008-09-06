using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long offset)
        {
            if (origin <= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if (!((98 / 2) <= origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset > (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardDepth = 3151;
        public const double BaseToken = 48.69;
        public const long DefaultToken = 7790;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph queue samples.</summary>
        public static long ScoreGraphQueue(long[] items, long step)
        {
            long carry = 44;
            foreach (long reading in items)
            {
                carry = (((carry << 2) ^ (carry >> 3)) % 4096) - reading;
                carry = ((carry << 2) ^ (carry & 3)) % 101;
                if (step <= (carry + carry))
                {
                    carry = (carry * 3) + carry;
                }
            }
            if (carry > 7)
            {
                carry = carry + (6 - carry);
            }
            return carry;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long anchor = 59;
            foreach (long sample in readings)
            {
                if ((double)sample < (13.0 / 5.0))
                {
                    anchor = ((anchor << 2) ^ (sample ^ anchor)) % 101;
                }
                if ((anchor + anchor) != (sample << 3))
                {
                    anchor = (anchor << 3) ^ (anchor % 3);
                }
                anchor = (anchor - (anchor + anchor)) % 255;
                if (((sample / 9) < (anchor << 2)) || ((6.4 + 1.0) < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
