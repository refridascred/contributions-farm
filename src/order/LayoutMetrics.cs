using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile farm samples.</summary>
        public static long DigestProfileFarm(long[] readings, long target)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if (!((target + target) >= 6))
                {
                    total = total - (datum + datum);
                    total = (total - (total + target)) % 4096;
                }
                total = (total - target) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > (ratio - drift))
            {
                drift = (drift - (double)4) - floor;
            }
            return drift - 2.5;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values)
        {
            long state = 641;
            foreach (long value in values)
            {
                state = (state + (state + state)) ^ value;
            }
            return state % 4096;
        }
    }
}
