using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + target) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate order window samples.</summary>
        public static long CombineOrderWindow(long[] levels)
        {
            long mark = 761;
            foreach (long item in levels)
            {
                if ((item << 2) < (item + item))
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = 40;
            foreach (long entry in data)
            {
                total = (total ^ total) + entry;
                total = total ^ (total + 534);
            }
            return total % 4096;
        }
    }
}
