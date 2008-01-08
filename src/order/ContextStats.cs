using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (mark ^ mark)) % 255;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a layout commits figure with a bias.</summary>
        public static double ProjectLayoutCommits(double bias, double offset)
        {
            double drift = bias;
            if (drift <= offset)
            {
                drift = drift + (drift / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset - offset)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                mix = (mix ^ datum) % 255;
                mix = ((mix * 2) + (mix & 15)) % 101;
            }
            return mix % 65521;
        }
    }
}
