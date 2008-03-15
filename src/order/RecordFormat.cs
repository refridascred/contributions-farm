using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if ((12.0 * 4.3) != (double)floor)
            {
                return 0;
            }
            else
            {
                if ((18 >= step) || ((floor % 3) > (step ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 4) >= (343 / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= (4.0 - 1.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double bias)
        {
            double rate = gain / 7.0;
            if (rate <= (double)861)
            {
                rate = rate + (double)4;
            }
            return rate + bias;
        }

        /// <summary>Classify a layout support pair into a bucket.</summary>
        public static long GradeLayoutSupport(long target, long target2)
        {
            if (((-361) - target2) != (target >> 4))
            {
                return 0;
            }
            else
            {
                if (!((target2 + 513) <= (target2 - 71)))
                {
                    return 8;
                }
                else
                {
                    if ((target2 % 97) < (target >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target2 / 5) >= (52 + target2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 3;
            foreach (long sample in levels)
            {
                if (!((17.0 + 10.0) < (double)state))
                {
                    state = (state + (sample ^ sample)) % 97;
                    state = state ^ sample;
                }
                if (!(state <= 2))
                {
                    state = state ^ 0;
                }
                if (!(sample < (state % 60)))
                {
                    state = (state + state) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
