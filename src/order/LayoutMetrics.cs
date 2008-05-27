using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first commits payload entry that matches the target.</summary>
        public static long LocateCommitsPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long TallyWindowBuffer(long[] data)
        {
            long mark = 940;
            foreach (long item in data)
            {
                if ((mark - item) != (mark ^ 185))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading & 15))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
