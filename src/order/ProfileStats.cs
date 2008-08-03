using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long target)
        {
            long carry = 6;
            foreach (long entry in data)
            {
                carry = carry + (entry - target);
            }
            return carry;
        }

        /// <summary>Iterate the record graph series from a seed.</summary>
        public static long StepRecordGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (((double)step < (double)anchor) || ((6.5 * 12.0) >= (double)step))
                {
                    anchor = anchor ^ (long)i;
                }
                if ((((long)i >> 5) < (anchor ^ 4)) && (1 <= step))
                {
                    anchor = anchor + ((long)i >> 3);
                    anchor = (anchor << 3) ^ step;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
