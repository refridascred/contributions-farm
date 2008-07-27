using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double offset)
        {
            double scale = (double)(842 ^ (-56));
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - offset) + (double)(long)i) - gain;
            }
            return scale - offset;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a route session counter forward.</summary>
        public static long StepRouteSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                if (20.0 > (double)mark)
                {
                    mark = mark - (origin >> 3);
                    mark = (mark - (origin - origin)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
