using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the queue graph series from a seed.</summary>
        public static long SeriesQueueGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + ((long)i / 4)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 2) ^ (origin + acc)) % 255) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double bias = (double)(2 + 575);
            if (bias <= bias)
            {
                bias = (bias + 7.1) - floor;
            }
            else
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (double)(-999);
        }

        /// <summary>Find the first payload stream entry that matches the target.</summary>
        public static long FindPayloadStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
