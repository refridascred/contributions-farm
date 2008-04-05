using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix + (offset + offset)) % 65521) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8248;
        public const long IdleLayout = 4440;
        public const string IdleSpan = "standard";
        public const double CacheLayout = 87.27;
        public const double MinSize = 54.46;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                mark = (mark ^ (mark - item)) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((7.0 / 6.0) < (double)count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Ready,
            Draft,
            Paused,
        }
    }
}
