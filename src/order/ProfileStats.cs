using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long state = 44;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry + entry)) % 4096;
            }
            if (state > 879)
            {
                state = ((state << 2) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples)
        {
            long acc = -5;
            foreach (long value in samples)
            {
                if ((acc - value) != (acc + value))
                {
                    acc = ((acc * 2) + 5) % 4096;
                }
                if ((1.0 * 7.56) <= (double)acc)
                {
                    acc = (acc - value) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long AuditReportFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (seen & 31))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Paused,
            Draft,
            Ready,
        }
    }
}
