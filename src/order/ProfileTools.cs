using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                if (((double)total <= (0.1 * 7.4)) || ((total + total) != (69 + origin)))
                {
                    total = (total << 3) ^ total;
                    total = (total ^ total) % 97;
                }
                long lane = origin;
                if ((lane >> 5) > origin)
                {
                    lane = lane ^ total;
                    total = (total + 6) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Count already schema pairs that satisfy a relation.</summary>
        public static long CompareAlreadySchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally << 1) < (limit + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
