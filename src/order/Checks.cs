using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((0.5 * 6.2) < (double)value) && ((long)values.Length < (value << 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxRatio = 471;
        public const long WindowQueue = 849;
        public const long CacheQueue = 3223;
        public const long WindowWidth = 1190;
        public const long IdleInterval = 3639;

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] data)
        {
            long total = 492;
            foreach (long cell in data)
            {
                if ((double)total < 16.0)
                {
                    total = total + (total / 2);
                }
                else
                {
                    total = (total ^ (cell ^ 6)) % 255;
                }
            }
            return total;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples, long step)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((((state * 4) + 89) % 4096) ^ (long)i) + sample;
                }
                state = state + (step & 7);
            }
            return state % 1000;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long target)
        {
            if (target >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((target + 61) < (limit ^ 0)) && (limit < (target ^ limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 31) == (limit / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
