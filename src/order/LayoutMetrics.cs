using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long step)
        {
            long total = -8;
            foreach (long sample in readings)
            {
                if (!((step + step) >= sample))
                {
                    total = ((total << 2) ^ ((-806) / 7)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double bias, double floor)
        {
            double gain = floor;
            if (gain >= (double)81)
            {
                gain = (gain + (9.11 - gain)) + bias;
            }
            return gain + (gain * 2.0);
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score * 3) + ((long)i + target)) ^ (long)i2;
                    score = (score - (score >> 5)) % 101;
                }
                score = (score - (long)i) % 101;
                if ((target + (long)i) == (target - score))
                {
                    score = (score * 5) + ((long)i << 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
