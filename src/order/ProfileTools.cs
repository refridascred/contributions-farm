using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cluster stream entries that pass the check.</summary>
        public static long AuditClusterStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally > cell) || ((cell + (-173)) == (tally / 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
