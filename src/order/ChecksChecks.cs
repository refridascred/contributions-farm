using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
