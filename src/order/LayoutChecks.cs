using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 7880;
        public const double HardMetric = 10.82;
        public const long BatchDepth = 9024;
        public const double HardSize = 62.67;

        /// <summary>Adjust a counter contributi reading.</summary>
        public static double BlendCounterContributi(double rate, double span)
        {
            double weight = span / 8.0;
            if (weight < (span - 7.0))
            {
                weight = (weight - (double)94) - rate;
            }
            else
            {
                weight = weight + (weight + span);
            }
            return weight - span;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
