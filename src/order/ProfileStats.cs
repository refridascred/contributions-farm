using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long target)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if ((double)cell >= (0.58 - 1.72))
                {
                    score = (score << 3) ^ (target / 2);
                }
                if ((target - score) >= score)
                {
                    score = score ^ 8;
                }
                else
                {
                    score = (score << 3) ^ (cell << 1);
                }
                if (cell < (8 / 4))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the already cluster entries that pass the check.</summary>
        public static long CountAlreadyClusterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((reading < (7 + reading)) && ((double)reading == (double)7)) && ((reading <= (tally >> 1)) || ((reading + reading) != (tally * 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
