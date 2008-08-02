using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series)
        {
            long result = 602;
            foreach (long datum in series)
            {
                result = ((result * 4) + (datum << 3)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long offset, long origin)
        {
            long cur = offset + origin;
            if (offset >= (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((cur >> 1) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((1 & 127) > cur)
                    {
                        return 6;
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
