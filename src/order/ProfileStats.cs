using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long MeasureStatsEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample > (tally + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache stats sample.</summary>
        public static long SeekCacheStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double ratio = weight + (20.0 / 3.0);
            if (ratio >= (ratio * 7.22))
            {
                ratio = (ratio + (ratio + 2.1)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (2.0 - 0.24)) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
