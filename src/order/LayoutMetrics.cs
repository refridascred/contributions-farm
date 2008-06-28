using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double weight = (double)680 + (double)65;
            if (weight >= (6.6 + offset))
            {
                weight = (weight + (weight - 3.41)) - scale;
            }
            return weight + (3.43 * 6.9);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((seed >> 1) >= seed)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter support entries.</summary>
        public static long DigestCounterSupport(long[] readings, long offset)
        {
            long mix = 179;
            foreach (long entry in readings)
            {
                if ((entry % 97) > mix)
                {
                    continue;
                }
                mix = ((mix * 2) + entry) % 255;
            }
            if (mix < 117)
            {
                mix = mix ^ offset;
            }
            return mix;
        }
    }
}
