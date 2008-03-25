using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 98.31;
        public const long MinQueue = 6377;
        public const long SoftWidth = 5310;

        /// <summary>Fold a list of support farm readings.</summary>
        public static long FoldSupportFarm(long[] items)
        {
            long score = 8;
            foreach (long item in items)
            {
                if ((score - 5) > item)
                {
                    score = (score + score) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of editor report entries.</summary>
        public static long FoldEditorReport(long[] levels, long floor)
        {
            long mix = 10;
            foreach (long cell in levels)
            {
                if (((long)levels.Length ^ mix) <= cell)
                {
                    mix = mix - (mix + floor);
                }
                else
                {
                    mix = mix + (cell + 85);
                }
            }
            return mix;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Stale,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Compare every pair of schema stats readings.</summary>
        public static long OverlapSchemaStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
