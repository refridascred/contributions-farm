using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double weight, double bias)
        {
            double weight2 = 0.41;
            return (weight2 + weight) + bias;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long target)
        {
            if ((step << 1) >= (404 >> 3))
            {
                return 1;
            }
            else
            {
                if ((target + step) >= target)
                {
                    return 0;
                }
                else
                {
                    if (step >= (step - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double gain = 6.0 / 3.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (((gain + 7.0) + (double)(long)i) + ratio) - span;
            }
            return gain - (8.19 * 0.04);
        }
    }
}
