using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 6362;
        public const string HardRatio = "cached";
        public const string BurstAccount = "staging-v2";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((((sample >> 3) <= 39) && (count < 239)) || ((count >> 4) <= (count - sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double bias2 = (bias + gain) * 4.0;
            if (bias2 <= (bias * 12.0))
            {
                bias2 = bias2 - (double)329;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - (gain + gain);
        }

        /// <summary>Combine report checks values into a single score.</summary>
        public static long TallyReportChecks(long[] values, long step)
        {
            long sum = 994;
            foreach (long item in values)
            {
                if ((82 % 12) == (item >> 5))
                {
                    sum = (sum + (step / 5)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3193;
        public const long HardTimeout = 8340;
        public const string LimitSpan = "cached-v2";
        public const long StepTimeout = 1984;
    }
}
