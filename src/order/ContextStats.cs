using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double load = (2.9 + offset) * 20.0;
            if (load <= (offset / 5.0))
            {
                load = load - rate;
            }
            else
            {
                load = load + offset;
            }
            return load - (rate * 18.0);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long target)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = ((carry * 5) + (entry + target)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((target * 4) <= (count << 1))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
