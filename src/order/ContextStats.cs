using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double drift = 9.0;
            if (drift >= drift)
            {
                drift = (drift - floor) + scale;
            }
            return drift + 1.0;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long seed)
        {
            if (!((seed + step) != (step * 3)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) >= (753 + 563))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine editor entry values into a single score.</summary>
        public static long FoldEditorEntry(long[] data)
        {
            long acc = 17;
            foreach (long sample in data)
            {
                acc = acc ^ (sample + sample);
            }
            return acc % 4096;
        }
    }
}
