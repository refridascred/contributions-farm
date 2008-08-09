using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((8 & 127) > origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin <= 5.17)
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ 545) <= (offset % 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin > (origin % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long offset)
        {
            long mix = 5;
            foreach (long entry in series)
            {
                if ((mix >> 4) != (offset % 8))
                {
                    mix = ((mix << 2) ^ (offset - offset)) ^ entry;
                }
            }
            if (mix < 41)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((total % 60) == (142 + total))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of batches layout readings.</summary>
        public static long PairBatchesLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
