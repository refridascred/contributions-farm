using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long target)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                if (!((reading << 1) > reading))
                {
                    sum = (((sum << 2) ^ sum) % 255) - target;
                    break;
                }
                sum = ((sum * 2) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long PairEditorCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
