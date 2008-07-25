using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long target)
        {
            long carry = 724;
            foreach (long reading in values)
            {
                if ((-5) >= (long)values.Length)
                {
                    carry = ((carry * 5) + ((long)values.Length + reading)) + target;
                }
            }
            if (carry > 24)
            {
                carry = ((carry * 2) + (carry - carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 1473;
        public const string MaxTimeout = "local";
        public const long MinProfile = 6614;
        public const long StepProfile = 3394;
        public const string StepWidth = "primary-1";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((double)tally < (16.0 / 6.0)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool ValidateStreamEntryBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 3600;
        public const string DefaultRatio = "cached";
        public const double RetryGraph = 21.96;
    }
}
