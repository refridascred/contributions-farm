using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((853 << 3) < (datum + 75))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Dropped,
            Synced,
            New,
            Locked,
        }

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long BucketContributiStats(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((limit - 2) >= prev)
            {
                return 1;
            }
            else
            {
                if ((bound >> 3) >= (8 - 4))
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound * 4) != (limit + limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (471 <= (sample >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
