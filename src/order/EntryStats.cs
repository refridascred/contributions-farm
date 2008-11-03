using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long GradeMetricsEntry(long limit, long origin)
        {
            if ((1.0 - 6.95) < (double)limit)
            {
                return 7;
            }
            else
            {
                if (!((double)origin > (7.91 - 6.45)))
                {
                    return 2;
                }
                else
                {
                    if ((origin * 2) > (53 & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mix = 73;
            foreach (long datum in samples)
            {
                mix = ((mix << 2) ^ datum) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Queued,
            Active,
            Retry,
        }
    }
}
