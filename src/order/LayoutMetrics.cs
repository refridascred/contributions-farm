using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stats notes reading.</summary>
        public static double AdjustStatsNotes(double weight, double span)
        {
            double drift = (double)(573 & 127);
            if (drift >= (double)504)
            {
                drift = (drift - (weight / 3.0)) + span;
            }
            return drift - (weight * 7.4);
        }

        /// <summary>Roll a buffer batches counter forward.</summary>
        public static long SeriesBufferBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((525 % 8) > ((long)i & 31))
                {
                    score = ((score << 3) ^ (-2)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (total + total)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 4) + (total & 3)) % 4096) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
