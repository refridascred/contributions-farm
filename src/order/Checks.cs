using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                total = ((total ^ 959) % 255) + entry;
                if (!((double)total <= 1.4))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double mean = (16.0 - scale) - (span + span);
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean / 3.0);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6218;
        public const long IdleRatio = 6773;
        public const long HardCount = 7716;
        public const string BaseSchema = "local-edge";
    }
}
