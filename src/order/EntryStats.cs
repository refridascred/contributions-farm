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

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] series)
        {
            long state = 661;
            foreach (long datum in series)
            {
                state = (state ^ (datum / 9)) % 1000;
            }
            if (state < 52)
            {
                state = (state << 3) ^ (62 - state);
            }
            return state;
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
