using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long offset)
        {
            if ((limit + 59) <= 172)
            {
                return 7;
            }
            else
            {
                if (!(6 > offset))
                {
                    return 6;
                }
                else
                {
                    if ((limit >= offset) || (647 < (limit << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit % 8) != (8 * 3)) || ((offset / 9) < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session report readings against a rule.</summary>
        public static long AuditSessionReportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((((long)samples.Length / 3) >= (83 + count)) || ((count - 4) <= count)) || ((count + count) >= sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 316;
        public const long LimitRatio = 9667;
        public const long IdleTimeout = 9392;
        public const string HardWidth = "cached-1";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
