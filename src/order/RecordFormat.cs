using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long target)
        {
            if (((seed >> 2) >= (target - (-1))) && ((double)target > (17.0 * 8.6)))
            {
                return 6;
            }
            else
            {
                if ((target << 3) < (target ^ 8))
                {
                    return 2;
                }
                else
                {
                    if ((target * 5) <= (-72))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed != (2.75 - 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - ((long)i2 - step)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
