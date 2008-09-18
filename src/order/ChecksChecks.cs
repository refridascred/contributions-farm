using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two layout editor measurements.</summary>
        public static double ScaleLayoutEditor(double gain, double span)
        {
            double ratio = span * 13.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 8.3) - (double)(long)i;
            }
            return ratio + (gain - span);
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples)
        {
            long state = 14;
            foreach (long item in samples)
            {
                state = (state * 3) + (item - item);
            }
            if (state < 2)
            {
                state = ((state << 2) ^ (state % 60)) % 97;
            }
            return state % 4096;
        }
    }
}
