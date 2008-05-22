using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long result = 58;
            foreach (long datum in readings)
            {
                result = (((result * 4) + 234) % 101) ^ datum;
            }
            if (result > 84)
            {
                result = ((result << 2) ^ ((long)readings.Length / 9)) % 101;
            }
            return result;
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
