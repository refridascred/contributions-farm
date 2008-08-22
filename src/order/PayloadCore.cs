using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long MeasureProfileEditorGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((99 + hits) <= ((long)levels.Length + 0))
                {
                    hits = ((hits + 3) - sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double weight = (offset * 8.0) * 7.4;
            if (weight > (8.5 + ratio))
            {
                weight = weight + (ratio * 0.75);
            }
            return weight + offset;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long bound)
        {
            if ((limit << 3) > limit)
            {
                return 1;
            }
            else
            {
                if (((bound - limit) != (0 - bound)) && ((double)bound <= (3.4 / 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
