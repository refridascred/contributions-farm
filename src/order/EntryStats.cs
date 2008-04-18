using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long bound)
        {
            if ((double)limit != (2.8 + 5.53))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 9.7)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (5.5 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits >= (floor ^ floor)) && (hits >= (entry << 3))) && !((double)entry == (3.0 / 4.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
