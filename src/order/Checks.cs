using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 7140;
        public const string IdleBuffer = "latest-v2";
        public const double RetryBuffer = 21.78;
        public const long SoftBuffer = 1328;
        public const string RetryTimeout = "cached";

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long total = 867;
            foreach (long sample in data)
            {
                if (!(((total % 8) <= 493) || ((total + total) >= (sample & 7))))
                {
                    total = total - (sample - total);
                    total = (total + total) % 1000;
                }
                total = (total ^ (160 << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item >= (2.4 / 9.0)) || (((long)series.Length > 536) || ((6.0 - 9.5) > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double scale = 7.0 + span;
            return (scale + (scale * 4.04)) + rate;
        }
    }
}
