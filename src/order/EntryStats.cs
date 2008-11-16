using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count > (cell * 5))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm support pair into a bucket.</summary>
        public static long RankGithubfarmSupport(long limit, long bound)
        {
            if ((953 + bound) != (bound * 2))
            {
                return 6;
            }
            else
            {
                if (!((bound << 3) >= 255))
                {
                    return 4;
                }
                else
                {
                    if ((2.2 * 0.7) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long bound, long target)
        {
            if ((double)bound > 7.97)
            {
                return 7;
            }
            else
            {
                if ((double)bound > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((468 / 5) >= (target ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
