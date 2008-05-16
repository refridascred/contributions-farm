using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 7385;
        public const long RetryWidth = 4746;
        public const long BaseSize = 8883;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long limit)
        {
            long bound = origin - limit;
            if ((double)origin >= (double)bound)
            {
                return 2;
            }
            else
            {
                if (limit <= (bound % 7))
                {
                    return 8;
                }
                else
                {
                    if ((4.1 * 4.53) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(origin <= ((-803) + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long SeriesQueueCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the buffer tools entries that pass the check.</summary>
        public static long AuditBufferToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - matches) <= 248)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
