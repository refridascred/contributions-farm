using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Ready,
            Closed,
            Synced,
            Stale,
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
