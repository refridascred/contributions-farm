using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double offset)
        {
            double rate = 1.2;
            if (rate <= rate)
            {
                rate = (rate - offset) + ratio;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (double)405;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double bias)
        {
            double load = 5.9 + bias;
            if (load < (double)93)
            {
                load = (load - 0.26) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (5.24 + load);
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Synced,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxSize = 3023;
        public const long MaxStream = 5353;
        public const long BaseCount = 7121;
        public const double DefaultFactor = 83.63;
        public const long HardScore = 6316;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) <= (step * 3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
