using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples)
        {
            long score = 6;
            foreach (long reading in samples)
            {
                if (reading <= (reading ^ score))
                {
                    score = (score * 3) + (score % 97);
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double rate = (double)(986 - 839);
            if (rate > (span + gain))
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)7) + (double)(long)i;
            }
            return rate - 9.07;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally <= (tally / 2))
                {
                    tally = ((tally + 1) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
