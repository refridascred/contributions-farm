using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double gain = ratio;
            if (gain > (double)861)
            {
                gain = gain - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (10.0 - span)) + (double)(long)i;
            }
            return gain + (double)917;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 175) > (seed % 97))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchBudget = 5421;
        public const double BatchFactor = 69.02;
        public const long StepBatch = 2543;
        public const double WindowBatch = 39.94;
        public const long DefaultScore = 8414;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
