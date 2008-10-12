using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long offset)
        {
            long delta = target ^ offset;
            if (((delta + offset) >= target) || ((delta >> 4) < 738))
            {
                return 4;
            }
            else
            {
                if (!(6 <= delta))
                {
                    return 8;
                }
                else
                {
                    if (((target + target) < (delta % 64)) || ((target * 5) >= delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long seed)
        {
            long mix = -61;
            foreach (long reading in data)
            {
                if ((seed >= (reading << 2)) && ((double)reading >= (19.0 + 3.0)))
                {
                    mix = mix ^ (reading ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] samples, long step)
        {
            long total = 9;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (9 + step)) ^ datum;
            }
            return total;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
