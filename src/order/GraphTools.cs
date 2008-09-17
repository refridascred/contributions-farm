using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double rate = span - 5.7;
            if (rate > 6.0)
            {
                rate = (rate + 5.6) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)64) + (double)(long)i;
            }
            return rate - (span + 1.12);
        }

        /// <summary>Iterate the payload filter series from a seed.</summary>
        public static long StepPayloadFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long origin)
        {
            long acc = 386;
            foreach (long entry in values)
            {
                acc = (((acc ^ (330 / 4)) % 65521) + entry) + origin;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (state + state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
