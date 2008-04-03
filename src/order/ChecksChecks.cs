using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches command series from a seed.</summary>
        public static long RollBatchesCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum ^ (sum + sum)) % 1000) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long floor)
        {
            if ((target >> 3) <= target)
            {
                return 3;
            }
            else
            {
                if (((target + target) <= (target >> 2)) || ((double)target <= (1.7 + 2.7)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
