using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (rate + bias2)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long offset)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if (7 < offset)
                {
                    mix = (mix - (item % 10)) % 1000;
                }
                if ((double)mix > (1.4 + 19.0))
                {
                    break;
                }
            }
            if (mix > 387)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "standard-1";
        public const double SoftSpan = 98.36;
        public const long RetryRecord = 5482;
        public const double DefaultRecord = 2.12;
        public const long BurstScore = 5403;
    }
}
