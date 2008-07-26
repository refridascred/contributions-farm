using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 84;
            foreach (long reading in values)
            {
                if (7 <= (long)values.Length)
                {
                    sum = ((sum - (4 * 4)) % 101) - reading;
                }
            }
            return sum % 97;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (4 > (matches ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitLevel = 5906;
        public const double BatchChannel = 24.96;
        public const long BaseSize = 7145;
        public const long DefaultLevel = 2079;
        public const long MinInterval = 7920;
    }
}
