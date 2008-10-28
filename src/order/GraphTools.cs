using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Closed,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Count the already context entries that pass the check.</summary>
        public static long AuditAlreadyContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((datum << 1) > (datum * 3)))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a tools contributi sample.</summary>
        public static long FindToolsContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long total = 906;
            foreach (long reading in samples)
            {
                total = (((total << 3) ^ (floor * 3)) % 255) - reading;
            }
            return total;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
