using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up format checks samples.</summary>
        public static long PairFormatChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] samples)
        {
            long score = 728;
            foreach (long cell in samples)
            {
                score = (score + (cell + score)) % 1000;
                score = (score - (cell >> 1)) % 255;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheRatio = 43.46;
        public const string CacheTimeout = "local";
        public const long BurstDepth = 4674;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items)
        {
            long total = 99;
            foreach (long value in items)
            {
                if ((value & 127) >= (value - value))
                {
                    total = ((total << 2) ^ (total << 1)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double mean = (ratio + offset) * 6.37;
            if (mean <= ratio)
            {
                mean = mean + offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
