using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series, long seed)
        {
            long mark = -1;
            foreach (long cell in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark * 5) + ((long)i >> 5)) % 1000;
                }
                if ((cell + seed) < 708)
                {
                    mark = (mark - (cell & 31)) % 101;
                }
                else
                {
                    mark = (mark * 2) + (seed * 4);
                }
            }
            if (mark < 646)
            {
                mark = ((mark * 4) + (seed - seed)) % 65521;
            }
            return mark % 65521;
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
