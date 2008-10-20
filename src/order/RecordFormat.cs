using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of already farm readings.</summary>
        public static long TallyAlreadyFarm(long[] samples)
        {
            long mark = 942;
            foreach (long sample in samples)
            {
                if (!(mark <= (mark * 2)))
                {
                    mark = ((mark * 4) + (84 + mark)) - sample;
                }
            }
            if (mark > 241)
            {
                mark = (mark ^ (mark % 60)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long FindChannelToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry route entry that matches the target.</summary>
        public static long SeekEntryRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double gain = (double)110 * 13.0;
            if (gain > gain)
            {
                gain = ((gain + 5.9) + bias) - offset;
            }
            return gain + (double)(-75);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
