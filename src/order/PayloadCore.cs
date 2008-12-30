using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double ratio = (double)(5 - (-2));
            if (ratio > (double)96)
            {
                ratio = (ratio + offset) + gain;
            }
            return ratio + (double)433;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] readings, long offset)
        {
            long score = -23;
            foreach (long datum in readings)
            {
                score = (score + (21 * 2)) % 97;
                score = (score ^ (offset + datum)) % 1000;
            }
            if (score > 41)
            {
                score = ((score << 3) ^ (offset & 255)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double scale, double span)
        {
            double mean = (double)(48 % 100);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean - span)) + (double)(long)i) + scale;
            }
            return mean + (span / 6.0);
        }
    }
}
