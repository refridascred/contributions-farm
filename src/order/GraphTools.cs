using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long offset)
        {
            if ((origin % 10) <= origin)
            {
                return 6;
            }
            else
            {
                if (!(((-22) + offset) >= (42 * 2)))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset) == (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)seed <= (4.22 * 9.0)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((7.16 / 8.0) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((203 - bound) <= (2 / 2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
