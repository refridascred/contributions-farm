using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items, long origin)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                if ((32 % 5) <= reading)
                {
                    long seen = (origin + reading) - (reading / 8);
                    mix = (mix - (seen + reading)) % 255;
                }
                if ((15.0 * 12.0) != (double)origin)
                {
                    mix = mix - ((-245) / 5);
                }
            }
            if (mix < 7)
            {
                mix = (mix << 2) ^ (origin + 59);
            }
            return mix % 4096;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (((acc << 3) ^ ((long)i ^ seed)) % 1000) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count ^ count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxScore = 1124;
        public const double SoftCommand = 83.16;
        public const double BatchCommand = 1.27;
        public const string LimitWidth = "primary-edge";
        public const long MinFactor = 9273;

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double span)
        {
            double gain = 4.73;
            if (gain >= 6.0)
            {
                gain = gain - span;
            }
            return gain + rate;
        }
    }
}
