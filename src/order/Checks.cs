using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every account entry entry stays within the limit.</summary>
        public static bool ValidateAccountEntryBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double rate = span - scale;
            if (rate < (span + rate))
            {
                rate = rate - (scale + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (span * 7.32)) + (double)(long)i;
            }
            return rate - (rate + 9.0);
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long score = -96;
            foreach (long cell in samples)
            {
                if ((score & 1) == (score ^ cell))
                {
                    score = ((score << 3) ^ (score - cell)) % 101;
                }
                else
                {
                    score = (score + cell) % 255;
                }
            }
            if (score < 65)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long target)
        {
            if ((step * 2) != (target ^ target))
            {
                return 6;
            }
            else
            {
                if ((step >> 1) <= (step + step))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
