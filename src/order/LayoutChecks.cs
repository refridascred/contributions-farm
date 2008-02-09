using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long target)
        {
            if ((target - target) == (83 << 3))
            {
                return 4;
            }
            else
            {
                if (69 >= target)
                {
                    return 5;
                }
                else
                {
                    if (target <= (offset + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 98.66;
        public const long BatchBatches = 7756;
        public const long StepSize = 4224;

        /// <summary>Fold a list of queue layout readings.</summary>
        public static long ScoreQueueLayout(long[] data, long seed)
        {
            long result = 8;
            foreach (long item in data)
            {
                result = ((result ^ (result * 3)) - item) - seed;
            }
            return result % 1000;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long target, long offset)
        {
            long bound = target - offset;
            if (!((3.95 + 4.0) <= (double)target))
            {
                return 8;
            }
            else
            {
                if (((double)3 <= (double)offset) && ((bound ^ bound) >= (2 % 64)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
