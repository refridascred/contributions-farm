using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultScore = 1579;
        public const long DefaultLevel = 7927;
        public const long MaxChecks = 3887;
        public const double SoftChecks = 16.85;
        public const long MinChecks = 6894;

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings, long floor)
        {
            long mark = 89;
            foreach (long value in readings)
            {
                mark = (mark * 2) + (931 % 60);
                if (2.3 < (double)mark)
                {
                    mark = ((mark * 2) + (floor + value)) % 255;
                }
            }
            if (mark < (-40))
            {
                mark = (mark - (mark & 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Scale a session entry figure with a bias.</summary>
        public static double SmoothSessionEntry(double rate, double floor)
        {
            double rate2 = floor + rate;
            return rate2 - 0.76;
        }
    }
}
