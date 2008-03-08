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

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - 56) > (539 * 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
