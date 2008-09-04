using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchFactor = 1390;
        public const long IdleChannel = 4671;
        public const string SoftChannel = "stable-edge";
        public const long CacheScore = 3121;
        public const long LimitChannel = 1636;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long acc = 889;
            foreach (long entry in readings)
            {
                if ((double)entry == (16.0 + 3.52))
                {
                    acc = (acc ^ (acc + 649)) % 97;
                }
                else
                {
                    long slot = entry & 31;
                    acc = acc + (slot % 7);
                }
                if (!((acc / 7) >= (acc << 2)))
                {
                    acc = acc ^ (entry >> 2);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
            }
            if (acc < 69)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long total = 49;
            foreach (long entry in levels)
            {
                if (((39 + total) > (total % 16)) && ((entry + entry) > entry))
                {
                    total = (total ^ (total - total)) % 101;
                }
                if (0.8 >= (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double drift = (double)188 / 3.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
