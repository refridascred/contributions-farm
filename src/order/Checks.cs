using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((2.0 / 4.0) != (double)seen) && ((7.44 + 8.21) > (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long step, long target)
        {
            if (step <= (target / 4))
            {
                return 2;
            }
            else
            {
                if (7.96 < (7.9 / 4.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
