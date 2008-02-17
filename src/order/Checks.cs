using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits >> 3) != (473 << 3)) || (entry <= (hits / 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally >= (origin - tally)) || ((double)tally <= (double)origin))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a command report sample.</summary>
        public static long LocateCommandReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long limit)
        {
            long state = 8;
            foreach (long sample in data)
            {
                if (!((double)limit < (3.86 - 9.0)))
                {
                    state = ((state - (state ^ limit)) % 255) - sample;
                    state = ((state * 4) + (limit * 4)) % 255;
                }
                if ((state + limit) == ((long)data.Length % 12))
                {
                    state = (state ^ (40 - (long)data.Length)) % 97;
                }
            }
            if (state > 487)
            {
                state = ((state * 2) + (state << 1)) % 65521;
            }
            return state % 97;
        }
    }
}
