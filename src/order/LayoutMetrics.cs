using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double weight = (double)((-4) << 3);
            if (weight >= (ratio + 5.89))
            {
                weight = (weight + ratio) - offset;
            }
            return weight - (weight * 16.0);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
