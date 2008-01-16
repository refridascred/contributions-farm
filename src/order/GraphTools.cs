using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Done,
            Ready,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((6.6 + 3.77) != (double)seen) && ((9 + bound) > (seen + seen)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if ((limit < (anchor - anchor)) && (reading < ((long)series.Length & 15)))
                {
                    anchor = ((anchor * 2) + (reading / 8)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
