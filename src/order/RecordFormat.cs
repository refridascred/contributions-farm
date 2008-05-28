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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((count << 3) == (count * 3)) && ((step * 5) <= (long)values.Length)) && !((entry << 2) == (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
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
