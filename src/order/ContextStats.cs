using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 24.72;
        public const long BurstBudget = 2508;
        public const string HardBuffer = "staging-v2";
        public const double BatchBuffer = 98.19;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample - bound) >= (bound >> 2)) && ((bound + 510) < (tally & 63)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = result - (8 & 127);
                if (!(((long)i ^ result) < step))
                {
                    result = result - (result % 3);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
