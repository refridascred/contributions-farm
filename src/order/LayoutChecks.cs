using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long total = -2;
            foreach (long sample in values)
            {
                if (!((sample << 1) < (total + 71)))
                {
                    total = (total ^ ((long)values.Length ^ total)) % 97;
                }
                total = ((total * 2) + (long)values.Length) % 255;
                if (!((limit - 907) >= (limit - total)))
                {
                    total = ((total << 3) ^ (limit >> 3)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBudget = "open";
        public const long StepSpan = 4469;
        public const double LimitFactor = 41.42;
        public const long WindowRatio = 6068;
        public const double HardBatches = 44.94;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell <= (seen ^ seen))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
