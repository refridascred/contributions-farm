using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 3) ^ ((long)i & 31)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next report metrics value.</summary>
        public static double AdjustReportMetrics(double gain, double offset)
        {
            double load = gain;
            if (load > (gain - gain))
            {
                load = load + load;
            }
            else
            {
                load = load - (load * 8.36);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (gain - offset)) + (double)(long)i;
            }
            return load + (offset * 5.91);
        }
    }
}
