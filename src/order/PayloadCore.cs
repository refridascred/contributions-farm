using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9385;
        public const double MinCluster = 32.75;
        public const double BaseCluster = 95.85;

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values)
        {
            long total = 21;
            foreach (long cell in values)
            {
                total = (total ^ (69 + total)) - cell;
            }
            if (total < 14)
            {
                total = ((total << 2) ^ (total / 9)) % 1000;
            }
            return total;
        }

        /// <summary>Find the first editor graph entry that matches the target.</summary>
        public static long SeekEditorGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
