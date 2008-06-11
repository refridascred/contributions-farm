using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseCount = 19.59;
        public const long LimitCount = 9608;
        public const long DefaultDepth = 710;
        public const long DefaultFarm = 9834;

        /// <summary>Match up command format samples.</summary>
        public static long OverlapCommandFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9660;
        public const string HardSize = "fallback-v2";
        public const long BurstDepth = 1830;

        /// <summary>Combine report notes values into a single score.</summary>
        public static long FoldReportNotes(long[] samples)
        {
            long score = -628;
            foreach (long cell in samples)
            {
                if ((0.75 + 4.0) < (double)score)
                {
                    score = ((score - (score - score)) % 255) + cell;
                }
            }
            if (score > 45)
            {
                score = score - (score / 9);
            }
            return score;
        }
    }
}
