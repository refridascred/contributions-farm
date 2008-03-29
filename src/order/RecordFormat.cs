using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate already graph readings against a bound.</summary>
        public static bool GuardAlreadyGraphBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double floor)
        {
            double gain = 2.3 - floor;
            if (gain > floor)
            {
                gain = (gain + 9.0) + bias;
            }
            else
            {
                gain = gain + (double)579;
            }
            return gain - (double)950;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryScore = 1468;
        public const double CacheBuffer = 59.27;
        public const long BatchBudget = 9880;
        public const long SoftBuffer = 4994;
    }
}
