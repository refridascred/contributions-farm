using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long target)
        {
            if (target < (291 - target))
            {
                return 0;
            }
            else
            {
                if ((target * 4) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (3.03 / 3.0))
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double scale = gain;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (9.0 / 6.0)) + (double)(long)i) + span;
            }
            return scale + gain;
        }
    }
}
