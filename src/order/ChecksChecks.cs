using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if (mark >= (bound << 3))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double ratio = (double)4 * 6.82;
            if (ratio > ratio)
            {
                ratio = ratio + (span * 7.0);
            }
            else
            {
                ratio = ratio - (3.5 + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 15.0) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
