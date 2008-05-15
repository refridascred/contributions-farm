using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long step)
        {
            long score = 2;
            foreach (long datum in readings)
            {
                score = (score - 50) ^ datum;
                if (!((step ^ score) >= (score * 4)))
                {
                    score = score + (score << 1);
                }
                if ((double)(long)readings.Length > (11.0 / 9.0))
                {
                    score = (score ^ (score % 8)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long floor)
        {
            long total = 0;
            foreach (long cell in levels)
            {
                if ((1.99 + 1.17) <= (double)cell)
                {
                    total = ((total << 3) ^ (cell ^ total)) - floor;
                }
                else
                {
                    total = total - (5 + 0);
                }
            }
            return total;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 4831;
        public const long MaxPayload = 9651;
        public const long BasePayload = 7868;
        public const long CachePayload = 1810;
        public const string StepFactor = "alpha-edge";

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (span / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + 1.0) - (double)(long)i;
            }
            return bias2 - (bias - span);
        }
    }
}
