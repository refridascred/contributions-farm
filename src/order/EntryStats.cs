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

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            Synced,
            Ready,
            Paused,
            Stale,
        }
    }
}
