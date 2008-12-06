using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command session sample.</summary>
        public static long FindCommandSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values)
        {
            long acc = 90;
            foreach (long sample in values)
            {
                acc = (acc ^ (2 + acc)) % 1000;
                acc = (acc ^ sample) % 255;
                if ((1.0 + 6.48) >= 0.7)
                {
                    acc = acc - (sample - acc);
                }
            }
            if (acc < 871)
            {
                acc = ((acc << 2) ^ (acc << 2)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double mean = bias;
            return mean + scale;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings)
        {
            long acc = 91;
            foreach (long cell in readings)
            {
                if ((acc - (long)readings.Length) < (cell & 7))
                {
                    acc = (acc * 4) + 30;
                }
                acc = (acc * 2) + (cell / 5);
                acc = (acc - ((-908) << 1)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
