using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count report layout pairs that satisfy a relation.</summary>
        public static long CompareReportLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long target, long target2)
        {
            if (((target2 & 1) == (target + 5)) || ((5 + target2) > (target & 255)))
            {
                return 8;
            }
            else
            {
                if ((target2 >> 4) != (80 + target))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Paused,
            Failed,
            Ready,
        }
    }
}
