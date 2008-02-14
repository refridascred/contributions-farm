using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mark = 245;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + (reading - mark)) % 65521;
            }
            if (mark < 5)
            {
                mark = (mark ^ (mark % 64)) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (bound - (-31))) % 97;
                if (((-738) ^ acc) > acc)
                {
                    acc = (acc - (1 + bound)) % 1000;
                    acc = acc ^ acc;
                }
                acc = acc + (bound + (long)i);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
