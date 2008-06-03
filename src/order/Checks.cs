using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits << 1) < (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long bound, long offset)
        {
            if ((bound % 8) != (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((double)bound > 6.0)
                {
                    return 6;
                }
                else
                {
                    if ((offset + bound) < (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
