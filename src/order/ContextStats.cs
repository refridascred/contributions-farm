using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = (total - (datum + datum)) % 4096;
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = (mix - (mix >> 3)) ^ cell;
                mix = mix ^ 89;
            }
            return mix;
        }
    }
}
