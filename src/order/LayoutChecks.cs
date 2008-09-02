using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            long span = bound + bound2;
            if ((span + (-9)) >= (span + bound))
            {
                return 4;
            }
            else
            {
                if (bound >= ((-69) - span))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.69 + 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen != (double)sample)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
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
