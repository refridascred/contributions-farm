using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits == (double)cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double bias2)
        {
            double ratio = (double)(6 % 64);
            if (ratio >= 0.1)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (bias2 + bias);
        }
    }
}
