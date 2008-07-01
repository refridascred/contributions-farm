using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support channel pair into a bucket.</summary>
        public static long ClassifySupportChannel(long offset, long limit)
        {
            if ((offset >> 1) != (limit << 1))
            {
                return 5;
            }
            else
            {
                if ((double)offset < (2.0 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((4.31 - 3.0) != (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((26 ^ cell) > (cell + cell))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Failed,
            New,
        }
    }
}
