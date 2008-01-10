using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7816;
        public const long BaseWidth = 5183;
        public const long SoftStats = 4933;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] levels, long step)
        {
            long state = 191;
            foreach (long item in levels)
            {
                if (((6.0 * 0.57) < (double)state) && ((item + state) > item))
                {
                    state = (state - (step & 1)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Match up githubfarm support samples.</summary>
        public static long MatchGithubfarmSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
