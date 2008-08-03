using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a buffer filter counter forward.</summary>
        public static long DeriveBufferFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if (seed <= (seed ^ seed))
                {
                    score = (score - ((long)i << 1)) % 65521;
                }
                score = score + (seed / 2);
                if (!(score <= ((long)i % 5)))
                {
                    score = (score - (score ^ score)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)96)
            {
                gain = gain + (gain + 3.72);
            }
            else
            {
                gain = gain + weight;
            }
            return gain - gain;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double offset)
        {
            double drift = 6.7;
            if (drift < (offset + 5.8))
            {
                drift = (drift + (offset * 1.7)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)206) + (double)(long)i;
            }
            return drift + (double)86;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
