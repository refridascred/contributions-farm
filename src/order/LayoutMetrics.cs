using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally % 2) >= (576 - (long)levels.Length))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double scale = bias;
            if (scale < (double)9)
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (7.6 * 7.44);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long total = -100;
            foreach (long cell in levels)
            {
                if ((cell & 7) <= 59)
                {
                    total = (total * 5) + (total & 31);
                    total = (total + total) % 255;
                }
                total = (total * 3) + (total / 2);
                if (15.0 >= (double)total)
                {
                    total = (total - (total / 5)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ (cell + total)) % 101;
                }
            }
            return total % 97;
        }
    }
}
