using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Draft,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((8.56 * 1.0) > (double)state) && (37 > state))
                {
                    state = ((state << 2) ^ (30 >> 5)) % 255;
                    state = (state - state) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double gain = offset + weight;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)41;
        }
    }
}
