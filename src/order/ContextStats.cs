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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
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
