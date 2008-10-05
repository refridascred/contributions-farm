using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 5517;
        public const long StepCluster = 6313;
        public const long MaxCluster = 3258;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((97 << 3) != (tally + tally))
                {
                    tally = ((tally + 3) + cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
