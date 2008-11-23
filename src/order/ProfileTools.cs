using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples, long step)
        {
            long total = 62;
            foreach (long datum in samples)
            {
                if ((304 ^ 888) <= total)
                {
                    total = (total - ((-134) + 988)) % 101;
                }
                if ((total & 1) <= datum)
                {
                    break;
                }
            }
            if (total > 388)
            {
                total = (total + step) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a contributi token value against two limits.</summary>
        public static long ClassifyContributiToken(long floor, long bound)
        {
            if (0 < floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) <= (bound + floor))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 2664;
        public const double RetryDepth = 36.38;
        public const double RetryEditor = 86.63;
        public const string WindowBudget = "primary";
        public const long BatchDepth = 4960;
    }
}
