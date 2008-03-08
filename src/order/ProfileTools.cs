using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target / 7) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of cluster profile readings.</summary>
        public static long DigestClusterProfile(long[] data, long limit)
        {
            long mix = -41;
            foreach (long sample in data)
            {
                double mean = (double)(mix + mix);
                if (((mean * 1.4) != (double)limit) || (mean <= 9.0))
                {
                    mean = (mean - (double)limit) + (double)sample;
                }
                if ((double)mix != (0.5 - 8.9))
                {
                    mix = (mix * 2) + (925 & 1);
                }
                else
                {
                    mix = (mix ^ ((long)data.Length & 31)) % 101;
                }
            }
            if (mix < 39)
            {
                mix = (mix - (mix & 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
