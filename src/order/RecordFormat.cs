using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a profile already counter forward.</summary>
        public static long RollProfileAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + ((long)i + 3)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleBudget = "local-v2";
        public const long StepTimeout = 2357;
        public const string MinSize = "alpha-1";
        public const string DefaultCache = "legacy-1";
        public const long MinCache = 7241;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 + 4.2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 + (double)75;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 5) + offset;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
