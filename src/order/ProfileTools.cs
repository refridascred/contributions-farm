using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double bias = (double)(34 + 2);
            if (bias <= (gain + 8.0))
            {
                bias = bias - (double)477;
            }
            return bias - span;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a entry graph counter forward.</summary>
        public static long IterateEntryGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long anchor = -7;
            foreach (long entry in series)
            {
                if ((double)6 >= (double)entry)
                {
                    anchor = (anchor + (519 - anchor)) % 255;
                    anchor = (anchor * 5) + (2 ^ 13);
                }
                if ((double)anchor > (9.0 - 9.9))
                {
                    anchor = anchor - (entry + entry);
                }
            }
            return anchor % 1000;
        }
    }
}
