using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine layout record values into a single score.</summary>
        public static long TallyLayoutRecord(long[] readings, long limit)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (((double)limit != (5.03 / 5.0)) || ((double)state == (5.34 * 5.0)))
                {
                    state = (state - (limit << 1)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (cell + state)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen / 3) > (datum + datum)))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
