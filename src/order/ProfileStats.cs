using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate account filter readings against a bound.</summary>
        public static bool VerifyAccountFilterLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings, long offset)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length != (double)cell)
                {
                    mix = (mix - (offset - offset)) % 65521;
                }
                mix = mix ^ cell;
                mix = (mix << 3) ^ (mix + mix);
            }
            if (mix > 761)
            {
                mix = (mix ^ (mix & 63)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 1381;
        public const double WindowMetric = 91.81;
        public const double HardDepth = 86.74;
        public const long LimitMetric = 3235;
    }
}
