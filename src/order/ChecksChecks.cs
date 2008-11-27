using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long CountFarmStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - 399) <= tally)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((bound >> 5) <= anchor)
                {
                    anchor = (anchor << 2) ^ (82 / 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
