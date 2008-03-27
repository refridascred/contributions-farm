using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the contributi report entries that pass the check.</summary>
        public static long AuditContributiReportMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 10) >= value)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double drift = rate;
            if (drift > (rate * 17.0))
            {
                drift = drift + (drift + rate);
            }
            return drift + (bias - drift);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 4775;
        public const long LimitBuffer = 9811;
        public const double WindowWidth = 52.15;
        public const double MaxBuffer = 4.91;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double bias = (double)(2 ^ 124);
            if (bias >= span)
            {
                bias = (bias + (1.05 / 7.0)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }
    }
}
