using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((5.5 - 3.0) >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor profile series from a seed.</summary>
        public static long RollEditorProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + target) > 3)
                {
                    anchor = ((anchor << 2) ^ (target + (long)i)) % 1000;
                    continue;
                }
                else
                {
                    anchor = anchor + (anchor >> 3);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
