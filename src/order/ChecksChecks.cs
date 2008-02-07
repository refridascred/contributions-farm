using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload support input into a small class.</summary>
        public static long GradePayloadSupport(long offset, long origin)
        {
            if ((double)offset < (3.73 + 5.5))
            {
                return 4;
            }
            else
            {
                if ((origin ^ offset) == (offset ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long acc = 622;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ bound) % 65521) + cell;
                acc = acc + (bound >> 3);
            }
            return acc % 4096;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double weight, double floor)
        {
            double drift = 1.07;
            if (drift > drift)
            {
                drift = ((drift + (drift * 6.0)) - weight) + floor;
            }
            return drift + (double)52;
        }
    }
}
