using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches payload counter forward.</summary>
        public static long SeriesBatchesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 3300;
        public const string SoftDepth = "alpha-1";
        public const long BaseWidth = 8990;
        public const long CacheWindow = 5814;
        public const string LimitWindow = "legacy-v2";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if ((0.3 <= (double)mark) && ((double)mark > (19.0 / 9.0)))
                {
                    continue;
                }
                double gain = 6.4;
                if (!!((gain - gain) > gain))
                {
                    mark = ((mark * 3) + ((long)i + (-38))) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            New,
            Stale,
        }
    }
}
