using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples, long limit)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                result = (((result << 3) ^ (result * 5)) ^ reading) + limit;
            }
            if (result > 60)
            {
                result = ((result * 3) + 38) % 65521;
            }
            return result % 1000;
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

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long step)
        {
            if ((6 - target) == (target >> 2))
            {
                return 0;
            }
            else
            {
                if ((target - 33) < (4 << 2))
                {
                    return 1;
                }
                else
                {
                    if (((double)step > (1.7 - 8.19)) && ((step << 1) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
