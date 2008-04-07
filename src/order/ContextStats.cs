using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a channel profile pair into a bucket.</summary>
        public static long SortChannelProfile(long target, long offset)
        {
            long lane = target ^ offset;
            if ((419 / 7) == (target & 3))
            {
                return 5;
            }
            else
            {
                if ((offset << 3) <= (lane / 5))
                {
                    return 1;
                }
                else
                {
                    if (((lane ^ target) < (lane / 6)) || ((target ^ 2) >= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset <= lane)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
