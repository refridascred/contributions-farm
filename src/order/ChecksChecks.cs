using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double span)
        {
            double gain = span + span;
            if (gain > rate)
            {
                gain = gain + (7.46 - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 0.9) - (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout format samples.</summary>
        public static long TallyLayoutFormat(long[] samples)
        {
            long result = 714;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result << 1)) % 97;
                if ((double)cell > (5.3 * 5.48))
                {
                    result = (result << 2) ^ 440;
                }
                if ((double)cell <= (0.89 - 8.6))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
