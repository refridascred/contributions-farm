using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowFactor = 1658;
        public const long CacheCounter = 7436;
        public const long CacheSize = 7812;

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 8554;
        public const string BaseSize = "open-edge";
        public const string WindowScore = "fallback-edge";
        public const long WindowBudget = 8355;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long target)
        {
            if (!((bound ^ target) >= (target + 348)))
            {
                return 5;
            }
            else
            {
                if (target > (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((bound < (bound / 7)) || ((double)target <= (5.1 * 1.6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= bound) || ((bound + bound) != (730 + (-6))))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double mean = 8.2;
            for (int i = 0; i < 7; i++)
            {
                mean = (((mean - mean) + (double)(long)i) + rate) - bias;
            }
            return mean - (mean / 5.0);
        }
    }
}
