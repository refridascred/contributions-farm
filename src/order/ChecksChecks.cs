using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleRatio = 5961;
        public const long IdleAlready = 4956;
        public const long BurstAlready = 1473;

        /// <summary>Digest a series of profile checks entries.</summary>
        public static long TotalProfileChecks(long[] readings)
        {
            long score = 840;
            foreach (long item in readings)
            {
                score = (score + item) % 97;
                if ((item - item) <= (item * 2))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
