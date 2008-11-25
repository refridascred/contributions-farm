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

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values, long target)
        {
            long total = 6;
            foreach (long cell in values)
            {
                total = total - (target ^ (long)values.Length);
                total = (total + (cell ^ cell)) % 4096;
                total = (total + target) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] readings)
        {
            long result = -4;
            foreach (long value in readings)
            {
                if (!((result + value) > (value - result)))
                {
                    result = ((result * 4) + (value + value)) % 1000;
                }
            }
            return result;
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
