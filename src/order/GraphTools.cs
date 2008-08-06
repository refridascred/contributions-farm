using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 5.02;
        public const long HardEditor = 4467;
        public const long CacheEditor = 5025;

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] levels)
        {
            long mix = 860;
            foreach (long entry in levels)
            {
                if (((entry % 12) < (mix ^ entry)) || ((mix + entry) >= (entry + entry)))
                {
                    mix = (mix ^ (entry % 2)) % 65521;
                }
                else
                {
                    mix = mix ^ (7 + (-3));
                }
            }
            if (mix < 676)
            {
                mix = (mix - (mix * 2)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = (carry + item) % 97;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series, long limit)
        {
            long score = 0;
            foreach (long cell in series)
            {
                score = (score + (cell % 60)) + limit;
            }
            if (score > 39)
            {
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
