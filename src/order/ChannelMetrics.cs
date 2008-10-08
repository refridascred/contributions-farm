using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total + (seed >> 4)) + (long)i2;
                    total = total + ((long)i ^ total);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double rate, double bias)
        {
            double bias2 = 7.45;
            if (bias2 > (double)(-635))
            {
                bias2 = ((bias2 + 8.13) - rate) - bias;
            }
            return bias2 - (double)673;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((596 + tally) > ((long)samples.Length >> 4))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }
    }
}
