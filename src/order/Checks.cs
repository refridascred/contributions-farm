using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first channel metric entry that matches the target.</summary>
        public static long LookupChannelMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9090;
        public const double BaseChannel = 69.93;
        public const long DefaultChannel = 602;
        public const double LimitSpan = 84.7;
        public const string IdleChannel = "alpha";

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((22 + (-7)) > (cell >> 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally << 1) < (4 + tally))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSpan = 39.66;
        public const long DefaultSupport = 3113;
        public const long BurstSupport = 6393;
        public const string RetryBudget = "standard-v2";
    }
}
