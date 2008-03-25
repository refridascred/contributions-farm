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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (19.0 + 2.7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double rate = weight;
            if (rate > (rate + 6.8))
            {
                rate = rate - (offset / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + 16.0;
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
