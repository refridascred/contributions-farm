using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long state = 373;
            foreach (long cell in readings)
            {
                if ((state - state) > 782)
                {
                    state = (((state << 3) ^ state) % 1000) + cell;
                }
            }
            return state;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double bias = offset / 9.0;
            return bias + (bias - weight);
        }
    }
}
