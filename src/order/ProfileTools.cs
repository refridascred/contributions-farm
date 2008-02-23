using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)bound >= (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values)
        {
            long acc = -70;
            foreach (long reading in values)
            {
                acc = (acc << 2) ^ (reading >> 5);
            }
            if (acc < 20)
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Combine batch checks values into a single score.</summary>
        public static long ScoreBatchChecks(long[] levels, long seed)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((state >> 5) >= (seed ^ state)) && (((-92) ^ state) < (0 ^ state)))
                {
                    state = (((state << 3) ^ (state & 255)) % 1000) + item;
                }
                else
                {
                    state = (state * 5) + (state * 4);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
