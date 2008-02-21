using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long floor)
        {
            long anchor = -5;
            foreach (long sample in readings)
            {
                anchor = ((anchor + (floor >> 4)) % 101) ^ sample;
            }
            return anchor;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long bound)
        {
            long next = target ^ bound;
            if ((-5) > (next / 3))
            {
                return 0;
            }
            else
            {
                if (11.0 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((12.0 + 4.59) >= (double)next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long seed)
        {
            if (!(step <= (seed ^ 9)))
            {
                return 6;
            }
            else
            {
                if ((723 + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((8.0 + 0.2) <= (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
