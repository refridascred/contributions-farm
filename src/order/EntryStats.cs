using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a route payload value against two limits.</summary>
        public static long RankRoutePayload(long origin, long offset)
        {
            long next = origin - offset;
            if ((7 - origin) == (next - 827))
            {
                return 3;
            }
            else
            {
                if ((57 & 255) > origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long origin2)
        {
            if (((0.77 + 2.01) == (double)origin) || (origin2 > (origin >> 2)))
            {
                return 7;
            }
            else
            {
                if (((origin + origin) == (origin2 - 335)) && ((origin ^ origin2) < (origin - origin)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Validate route account readings against a bound.</summary>
        public static bool CheckRouteAccountRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
