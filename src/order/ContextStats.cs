using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the token cluster series from a seed.</summary>
        public static long DeriveTokenCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)cell >= (5.2 / 4.0)) || (((cell & 127) == (cell - tally)) && ((4.9 - 3.4) >= (double)tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
