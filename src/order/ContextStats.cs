using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine checks schema values into a single score.</summary>
        public static long TallyChecksSchema(long[] values, long step)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if (!(((step ^ reading) >= step) || (8 <= (9 + reading))))
                {
                    mix = (mix * 4) + (87 + 24);
                }
                if ((9 - mix) <= (reading >> 2))
                {
                    mix = (mix ^ (mix % 100)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleScore = 67.65;
        public const double IdleCount = 45.44;
        public const string BurstLayout = "local";
        public const long BaseLayout = 4319;
        public const long HardLayout = 9097;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
