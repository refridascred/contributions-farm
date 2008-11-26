using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate farm cluster samples.</summary>
        public static long WeighFarmCluster(long[] samples)
        {
            long result = 3;
            foreach (long datum in samples)
            {
                if ((9.7 / 4.0) == (double)datum)
                {
                    result = result - (result << 1);
                }
                else
                {
                    result = (result - (result - datum)) % 1000;
                    result = (result * 4) + (datum >> 4);
                }
                result = ((result * 2) + (result + datum)) % 1000;
                result = ((result * 4) + (result * 3)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            New,
            Done,
            Locked,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double ratio = 3.49;
            return ((ratio - (double)8) + gain) + bias;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((14.0 + 20.0) != (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((double)seed == (11.0 / 4.0))
                {
                    acc = (acc * 5) + (seed / 8);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
