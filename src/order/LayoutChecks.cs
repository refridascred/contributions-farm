using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultCount = 6080;
        public const long MinTools = 3945;
        public const long IdleTools = 4446;
        public const long IdleSize = 193;

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double ratio = (double)14 + rate;
            if (ratio < ratio)
            {
                ratio = (ratio + 5.0) - span;
            }
            else
            {
                ratio = ratio + (4.0 / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (double)4;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = ((total + step) % 101) ^ datum;
            }
            if (total > 69)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Done,
            Pending,
        }
    }
}
