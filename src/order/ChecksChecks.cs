using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 74;
            foreach (long value in readings)
            {
                mix = (mix + value) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ (bound & 63)) % 1000;
                state = (state + (state >> 4)) % 255;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 3) ^ (bound - state)) % 255) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items, long step)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((step + 235) == ((-5) ^ (long)items.Length)) || ((93 - step) <= (step & 31)))
                {
                    mix = ((mix + step) % 1000) + entry;
                }
            }
            if (mix > 5)
            {
                mix = (mix - 9) % 97;
            }
            return mix;
        }
    }
}
