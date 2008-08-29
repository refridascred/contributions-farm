using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many context batch samples are out of range.</summary>
        public static long AuditContextBatchGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell / 4) > 515)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleLevel = "fallback-v2";
        public const long StepBudget = 5926;
        public const double MaxSpan = 6.86;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally ^ tally) <= tally) || ((tally ^ sample) >= (tally ^ (-100))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route report samples.</summary>
        public static long WeighRouteReport(long[] readings, long step)
        {
            long mix = -892;
            foreach (long sample in readings)
            {
                if ((11 % 16) < (186 - mix))
                {
                    mix = ((mix * 3) + step) % 65521;
                }
                else
                {
                    mix = (mix - (sample + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
