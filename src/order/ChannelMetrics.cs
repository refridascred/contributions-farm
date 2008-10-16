using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            if ((4.0 + 8.0) >= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((3 + origin) == ((-93) << 2))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (5.1 + 1.2)) || ((seed % 97) >= (53 >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
