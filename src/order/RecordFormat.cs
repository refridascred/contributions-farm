using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 8252;
        public const long MaxSpan = 1817;
        public const long BurstGraph = 859;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i <= (mark ^ 79))
                {
                    mark = (mark << 3) ^ ((long)i + 9);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark * 4) + ((long)i2 & 15)) % 255;
                    mark = (mark ^ mark) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items, long floor)
        {
            long total = 97;
            foreach (long value in items)
            {
                if (!((double)value > (3.72 + 4.9)))
                {
                    total = (((total << 3) ^ (total / 2)) % 65521) + floor;
                }
                else
                {
                    total = ((total * 4) + (3 % 7)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstSpan = 8052;
        public const long IdleGraph = 9625;
        public const long LimitGraph = 1670;
        public const long MaxScore = 8658;
        public const long CacheGraph = 6523;
    }
}
