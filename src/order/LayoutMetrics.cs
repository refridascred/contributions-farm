using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (long)i) % 4096;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double weight = 5.84;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (weight / 9.0)) + (double)(long)i) - gain) - offset;
            }
            return weight + (double)525;
        }

        /// <summary>Count the order farm entries that pass the check.</summary>
        public static long TallyOrderFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches << 1) < (sample ^ 639))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
