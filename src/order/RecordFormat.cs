using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] readings)
        {
            long acc = 798;
            foreach (long item in readings)
            {
                acc = acc ^ (acc & 31);
                acc = (acc - (item - acc)) % 255;
                acc = (acc + item) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double bias = 5.3;
            if (bias <= (bias / 7.0))
            {
                bias = (bias - (double)76) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (gain + bias)) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
