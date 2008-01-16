using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Paused,
            New,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double ratio = (double)(1 - 9);
            if (ratio >= (18.0 / 9.0))
            {
                ratio = ((ratio + (double)330) + scale) + offset;
            }
            else
            {
                ratio = ratio + (double)11;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items, long seed)
        {
            long acc = 949;
            foreach (long entry in items)
            {
                acc = (((acc ^ acc) % 4096) ^ entry) + seed;
                acc = (acc << 2) ^ 546;
                if (!((double)52 == (double)acc))
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 255;
                }
            }
            if (acc > (-6))
            {
                acc = (acc + (acc ^ acc)) % 97;
            }
            return acc;
        }
    }
}
