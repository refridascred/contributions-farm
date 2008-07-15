using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] readings, long step)
        {
            long state = 53;
            foreach (long datum in readings)
            {
                state = ((state + (step - state)) % 97) ^ datum;
            }
            if (state > (-99))
            {
                state = ((state * 3) + (state << 2)) % 255;
            }
            return state;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long step, long bound)
        {
            if (!(step < (step + 5)))
            {
                return 7;
            }
            else
            {
                if ((step * 3) <= (bound % 7))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
