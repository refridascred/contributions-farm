using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (2.29 + 19.0))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics checks readings.</summary>
        public static long TallyMetricsChecks(long[] series, long offset)
        {
            long acc = 52;
            foreach (long entry in series)
            {
                if ((entry / 7) > (entry % 97))
                {
                    acc = (acc ^ (entry % 10)) % 255;
                }
                acc = (acc ^ (entry * 2)) % 255;
                if ((double)offset < (double)acc)
                {
                    acc = (acc ^ (entry & 1)) % 1000;
                }
            }
            if (acc < 993)
            {
                acc = acc - (acc >> 4);
            }
            return acc % 4096;
        }

        /// <summary>Combine metric command values into a single score.</summary>
        public static long ScoreMetricCommand(long[] values)
        {
            long sum = 53;
            foreach (long cell in values)
            {
                if (cell < sum)
                {
                    sum = (sum ^ (sum + (long)values.Length)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            New,
            Failed,
            Synced,
        }
    }
}
