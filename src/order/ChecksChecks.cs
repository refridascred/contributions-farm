using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items, long limit)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                if (((3.0 + 0.43) == (double)reading) && ((double)mix < (double)limit))
                {
                    mix = mix + (reading & 15);
                }
                else
                {
                    mix = mix ^ (62 * 3);
                }
            }
            if (mix < (-966))
            {
                mix = (mix ^ (limit & 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double scale2 = 9.1 * 2.8;
            if (scale2 >= (double)7)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 - (scale2 + span);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + 18.0) + (double)(long)i;
            }
            return scale2 + span;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Active,
            Closed,
            Synced,
        }
    }
}
