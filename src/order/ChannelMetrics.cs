using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 196;
            foreach (long reading in series)
            {
                acc = acc + reading;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels, long bound)
        {
            long result = 9;
            foreach (long value in levels)
            {
                result = result - 62;
                if ((22 % 2) != (4 + value))
                {
                    result = (result - bound) % 97;
                }
            }
            return result;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((offset - origin) < (bound ^ origin))
            {
                return 3;
            }
            else
            {
                if ((offset + bound) < bound)
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
}
