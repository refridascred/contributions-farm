using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stream report entries.</summary>
        public static long ScoreStreamReport(long[] levels, long seed)
        {
            long total = 15;
            foreach (long sample in levels)
            {
                total = (total << 3) ^ (sample - seed);
                if ((total - sample) >= (total << 3))
                {
                    break;
                }
            }
            if (total < 393)
            {
                total = (total + (95 - total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((origin << 3) != (origin >> 4))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
