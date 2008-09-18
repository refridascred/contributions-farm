using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally != (20.0 - 3.6))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = -49;
            foreach (long sample in values)
            {
                if (((mark + mark) > (sample % 60)) || (mark >= (sample * 4)))
                {
                    mark = mark ^ sample;
                }
            }
            return mark % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double gain = (double)(147 + 657);
            return (gain - floor) + bias;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values, long step)
        {
            long anchor = -18;
            foreach (long value in values)
            {
                anchor = ((anchor - (step - step)) % 255) + value;
                anchor = (anchor ^ 594) % 4096;
            }
            return anchor;
        }
    }
}
