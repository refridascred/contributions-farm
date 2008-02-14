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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if (result <= (result - result))
                {
                    result = ((result * 5) + (9 - (long)i)) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
