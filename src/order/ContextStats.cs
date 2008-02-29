using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long target)
        {
            long total = -4;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (total + (datum >> 3)) % 101;
                    total = (total - (total ^ (long)i)) % 65521;
                }
                if ((double)datum != (4.6 + 4.76))
                {
                    total = ((total << 2) ^ (target % 12)) % 97;
                }
                if ((total + target) > (target + 410))
                {
                    total = (total - (target << 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every graph editor entry stays within the limit.</summary>
        public static bool ValidateGraphEditorRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (9.22 > (double)(long)samples.Length)
                {
                    seen = ((seen + 1) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
