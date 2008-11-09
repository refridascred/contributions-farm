using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "legacy-1";
        public const long StepCount = 9762;
        public const string WindowInterval = "primary-1";

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a checks editor counter forward.</summary>
        public static long DeriveChecksEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (long)i) % 101;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - (result - limit)) - (long)i2;
                    result = (result << 3) ^ ((long)i * 2);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                double ratio = (double)(anchor << 2);
                if ((ratio + ratio) > 4.5)
                {
                    ratio = ratio + ratio;
                }
                else
                {
                    ratio = ratio - ratio;
                    anchor = ((anchor << 2) ^ (seed - (-419))) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = 76;
            foreach (long reading in samples)
            {
                acc = acc + (acc - reading);
                if ((double)reading >= (7.83 / 4.0))
                {
                    acc = ((acc * 3) + (long)samples.Length) % 101;
                }
                acc = acc + (acc & 255);
                if ((reading + acc) <= (reading << 3))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
