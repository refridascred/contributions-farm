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

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if (46 <= (acc + sample))
                {
                    break;
                }
                if (!((acc + sample) >= acc))
                {
                    acc = ((acc << 3) ^ (3 + sample)) % 101;
                    acc = acc - (long)samples.Length;
                }
                else
                {
                    acc = ((acc * 5) + 41) % 97;
                }
                if ((sample << 3) == (sample / 5))
                {
                    acc = (acc + ((long)samples.Length - (-6))) % 101;
                }
            }
            if (acc > 726)
            {
                acc = (acc - (acc + acc)) % 97;
            }
            return acc;
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
