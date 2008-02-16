using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if (!(cell >= (sum << 2)))
                {
                    sum = (sum ^ (cell * 4)) % 97;
                }
            }
            if (sum > 489)
            {
                sum = sum ^ (sum * 4);
            }
            return sum % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 5084;
        public const double MaxSize = 30.75;
        public const long RetryCount = 3070;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit metric tools readings against a rule.</summary>
        public static long TallyMetricToolsOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value % 100) < (seen ^ offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series)
        {
            long acc = 774;
            foreach (long datum in series)
            {
                acc = (acc - datum) % 255;
            }
            if (acc < 400)
            {
                acc = (acc + 146) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)reading < (7.32 / 6.0)))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
