using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double rate = scale;
            return rate + (scale - bias);
        }

        /// <summary>Roll a record metric counter forward.</summary>
        public static long SeriesRecordMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] items)
        {
            long total = 12;
            foreach (long value in items)
            {
                total = (total ^ (total / 7)) - value;
            }
            return total;
        }

        /// <summary>Derive the next stream contributi value from a seed.</summary>
        public static long IterateStreamContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = (score ^ seed) % 101;
                if (!((seed + seed) <= ((long)i * 5)))
                {
                    score = score - (score % 97);
                    break;
                }
                else
                {
                    score = (score << 3) ^ (540 >> 1);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
