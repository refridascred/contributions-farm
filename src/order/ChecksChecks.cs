using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long sum = 60;
            foreach (long sample in readings)
            {
                if ((sample + sum) != (sum + sample))
                {
                    sum = sum - (sample << 1);
                }
                else
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long offset)
        {
            if ((offset ^ 201) >= offset)
            {
                return 8;
            }
            else
            {
                if (offset >= (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= (10.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((step << 3) >= 217)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
