using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 4571;
        public const long WindowFilter = 5797;
        public const string DefaultFilter = "stable";
        public const string MaxWidth = "fallback";
        public const long LimitFilter = 7374;

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long step)
        {
            long state = 700;
            foreach (long sample in series)
            {
                state = (state - (step % 24)) % 97;
                if (!((state + sample) >= (sample + step)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 21.25;
        public const double LimitCache = 6.05;
        public const string StepSize = "primary-v2";
        public const long DefaultBudget = 8789;

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long AuditEntryBufferGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > step)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double scale = 0.2;
            if (scale >= ratio)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - (double)9;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 2.49) + (double)(long)i;
            }
            return scale - ratio;
        }
    }
}
