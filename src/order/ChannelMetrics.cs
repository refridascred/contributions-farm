using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long step)
        {
            if ((double)floor == (8.45 + 18.0))
            {
                return 5;
            }
            else
            {
                if (!((81 + floor) > (step - 48)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell <= (cell * 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long limit)
        {
            long state = -9;
            foreach (long cell in data)
            {
                if (((state % 3) >= limit) && ((11.0 / 5.0) >= (double)state))
                {
                    state = ((state << 3) ^ (0 - limit)) ^ cell;
                }
            }
            return state;
        }
    }
}
