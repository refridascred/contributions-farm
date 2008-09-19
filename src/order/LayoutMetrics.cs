using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (bound - acc)) % 101;
                if ((2 < (acc >> 3)) || ((double)acc == (double)(long)i))
                {
                    acc = acc - (acc - 399);
                    acc = (acc - (long)i) % 4096;
                }
                else
                {
                    acc = (acc - ((long)i / 3)) % 4096;
                }
                acc = ((acc * 3) + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long result = 18;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = result ^ (long)i;
                    result = ((result << 3) ^ result) % 1000;
                }
                result = result ^ (17 - result);
                result = (result ^ (cell >> 5)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            New,
            Locked,
            Failed,
            Dropped,
        }
    }
}
