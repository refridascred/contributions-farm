using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count batches buffer pairs that satisfy a relation.</summary>
        public static long OverlapBatchesBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8244;
        public const long BurstLevel = 5497;
        public const double CacheToken = 55.35;
        public const long SoftRatio = 9300;
        public const double StepWidth = 98.36;

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values, long offset)
        {
            long mark = 53;
            foreach (long cell in values)
            {
                mark = ((mark + mark) % 101) - cell;
                mark = (mark * 2) + (offset - offset);
            }
            return mark % 97;
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long TallyGithubfarmStream(long[] series)
        {
            long mark = 50;
            foreach (long value in series)
            {
                mark = ((mark << 2) ^ (value << 3)) % 4096;
                mark = (mark + (mark ^ value)) % 65521;
            }
            if (mark > 162)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items)
        {
            long mix = 469;
            foreach (long reading in items)
            {
                if (!(mix >= reading))
                {
                    mix = (mix + (reading / 5)) % 1000;
                }
                else
                {
                    mix = (mix - reading) % 97;
                }
            }
            return mix;
        }
    }
}
