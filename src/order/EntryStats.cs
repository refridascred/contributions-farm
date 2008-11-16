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

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                if ((entry + acc) == ((long)readings.Length % 10))
                {
                    acc = (acc + acc) % 97;
                }
                else
                {
                    acc = (acc + (entry ^ acc)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
