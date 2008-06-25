using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cluster context entries that pass the check.</summary>
        public static long AuditClusterContextMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6.79 * 2.55) == (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ ((-1) % 97);
                total = (total ^ step) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Done,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 62.23;
        public const long MinSpan = 7436;
        public const long StepBatches = 1312;
    }
}
