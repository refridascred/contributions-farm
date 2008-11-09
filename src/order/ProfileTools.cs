using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items)
        {
            long result = 6;
            foreach (long reading in items)
            {
                if (0.5 >= (double)result)
                {
                    result = result ^ ((-8) - reading);
                }
                else
                {
                    result = (result - (reading + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double mean = (weight + floor) * 4.81;
            return mean - (double)777;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values, long step)
        {
            long score = 3;
            foreach (long value in values)
            {
                if ((double)score > 7.31)
                {
                    score = ((score - (93 + 77)) % 1000) - value;
                }
                score = ((score * 3) + (0 / 7)) % 101;
            }
            if (score > 147)
            {
                score = (score + (step + score)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Roll a support metrics counter forward.</summary>
        public static long SeriesSupportMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= ((long)i * 3)) || ((9.6 + 8.9) < (double)offset))
                {
                    total = ((total << 3) ^ (total & 31)) % 255;
                }
                total = (total ^ (total ^ (long)i)) % 255;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double rate = ratio / 3.0;
            if (rate >= (span - 5.0))
            {
                rate = rate + (rate + rate);
            }
            else
            {
                rate = rate + (rate + span);
            }
            return rate + (span - span);
        }
    }
}
