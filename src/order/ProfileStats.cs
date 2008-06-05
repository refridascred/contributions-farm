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

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long SeriesContributiTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 0) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (7 & 127)) % 97;
                score = (score - (limit - limit)) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
