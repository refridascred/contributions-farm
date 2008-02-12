using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a graph account reading.</summary>
        public static double ProjectGraphAccount(double weight, double floor)
        {
            double gain = (double)95 + floor;
            if (gain < gain)
            {
                gain = (gain - (gain / 6.0)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)5) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double gain = weight;
            if (gain > (gain / 9.0))
            {
                gain = gain - floor;
            }
            return gain + (gain * 3.84);
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
