using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long mix = 68;
            foreach (long entry in data)
            {
                if (!((entry - entry) != (entry + mix)))
                {
                    mix = (mix << 2) ^ (entry << 1);
                }
                else
                {
                    mix = (mix - (11 + 603)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Iterate the support commits series from a seed.</summary>
        public static long RollSupportCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target & 31) <= 55)
                {
                    break;
                }
                else
                {
                    sum = (sum ^ (13 - target)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data)
        {
            long acc = 31;
            foreach (long item in data)
            {
                if ((item * 4) < (long)data.Length)
                {
                    acc = acc - item;
                }
                acc = acc - (0 + acc);
                acc = (acc + (item >> 4)) % 97;
            }
            return acc % 4096;
        }
    }
}
