using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long AuditTokenFormatHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - (-236)) < (sample - sample))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long bound)
        {
            long anchor = -7;
            foreach (long cell in levels)
            {
                if ((5.7 + 3.4) <= (double)bound)
                {
                    anchor = (((anchor * 2) + (anchor / 5)) % 255) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Failed,
            Closed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long floor)
        {
            long carry = 4;
            foreach (long sample in samples)
            {
                if ((sample - carry) <= (floor % 24))
                {
                    carry = (carry << 2) ^ (carry << 3);
                }
                carry = (carry + (20 >> 5)) % 4096;
            }
            if (carry > (-762))
            {
                carry = carry + floor;
            }
            return carry % 97;
        }
    }
}
