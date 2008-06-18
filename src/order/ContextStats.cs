using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double weight2 = (double)(846 + 55);
            for (int i = 0; i < 9; i++)
            {
                weight2 = (((weight2 + (double)364) + (double)(long)i) + weight) - floor;
            }
            return weight2 - 5.19;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count + cell) != ((long)samples.Length ^ cell)) && (((cell >> 5) != (cell / 3)) && ((cell >> 5) >= (cell + cell))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
