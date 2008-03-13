using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long offset)
        {
            long mix = 65;
            foreach (long sample in samples)
            {
                if ((offset * 3) > mix)
                {
                    mix = ((mix * 2) + mix) % 97;
                }
                mix = mix + (sample << 2);
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long bound)
        {
            long carry = 93;
            foreach (long value in readings)
            {
                if (((carry + bound) == (508 - 847)) || ((carry << 2) > (9 - bound)))
                {
                    carry = ((carry + (bound & 1)) % 255) ^ value;
                }
            }
            return carry % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitRatio = "legacy-v2";
        public const long HardTimeout = 2498;
        public const string WindowEditor = "legacy-v2";
        public const long StepFactor = 8977;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 8603;
        public const double DefaultRoute = 44.0;
        public const double MinRoute = 6.37;

        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long CountAccountEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen != (3.5 - 9.93))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
