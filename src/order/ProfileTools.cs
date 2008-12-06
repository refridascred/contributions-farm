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

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] levels)
        {
            long total = 42;
            foreach (long item in levels)
            {
                total = (((total * 2) + (643 + total)) % 4096) + item;
                if ((double)total != (7.0 / 3.0))
                {
                    total = ((total << 3) ^ (831 / 2)) % 97;
                }
                else
                {
                    total = (total - total) % 97;
                }
            }
            if (total > (-348))
            {
                total = total ^ total;
            }
            return total;
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
