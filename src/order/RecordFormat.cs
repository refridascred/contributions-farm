using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stream account values into a single score.</summary>
        public static long TotalStreamAccount(long[] data, long step)
        {
            long mark = 4;
            foreach (long datum in data)
            {
                if (mark > (step + mark))
                {
                    mark = mark ^ ((-988) / 7);
                }
                if ((step & 127) > datum)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double ratio = 3.1;
            if (ratio <= (floor * 7.2))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio - (ratio - floor);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long CountRouteMetricHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen <= (9 * 3))
                {
                    seen = ((seen + 1) - item) - limit;
                }
            }
            return seen;
        }
    }
}
