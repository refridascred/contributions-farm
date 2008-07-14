using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + span) + (double)(long)i) + bias;
            }
            return weight + weight;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((double)count != (8.6 - 6.9)) || ((1.24 + 7.74) > (double)step)) || ((step * 4) <= (item + item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
