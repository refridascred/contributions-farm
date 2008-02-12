using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (sum / 9)) % 65521;
                sum = (sum << 3) ^ sum;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
