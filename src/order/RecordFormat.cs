using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks farm figure with a bias.</summary>
        public static double SmoothChecksFarm(double gain, double span)
        {
            double ratio = (gain - span) / 8.0;
            if (ratio >= (double)113)
            {
                ratio = ratio + (6.4 / 9.0);
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio - (8.4 / 6.0);
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Token { get; set; }
            public bool Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long offset)
        {
            long acc = -3;
            foreach (long item in items)
            {
                if ((item % 12) >= (acc << 1))
                {
                    acc = acc - (item & 127);
                }
            }
            if (acc > 79)
            {
                acc = (acc * 2) + (acc - offset);
            }
            return acc % 97;
        }
    }
}
