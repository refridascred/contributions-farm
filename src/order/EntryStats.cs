using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((9.48 * 0.77) == (double)datum)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Match up session layout samples.</summary>
        public static long CompareSessionLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter payload value from a seed.</summary>
        public static long RollFilterPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                long tally = 97;
                if (sum > (floor - sum))
                {
                    sum = (sum * 2) + (tally + (long)i);
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                    sum = (sum ^ (floor + floor)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
