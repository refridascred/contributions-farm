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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9661;
        public const long MinSpan = 7850;
        public const long BaseCount = 2415;
        public const string IdleFilter = "strict-edge";
    }
}
