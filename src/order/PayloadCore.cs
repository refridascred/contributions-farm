using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i ^ anchor) > target))
                {
                    anchor = anchor + target;
                }
                anchor = anchor - target;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((offset * 3) <= (reading / 8)) && (((offset % 97) <= offset) && ((offset - offset) < (624 % 24))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
