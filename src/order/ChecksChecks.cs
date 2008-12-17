using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 664;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + sum) % 1000) - cell;
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long target)
        {
            long state = 31;
            foreach (long reading in samples)
            {
                if (target > (state + 3))
                {
                    state = (state - target) ^ reading;
                }
                if ((double)state > 16.0)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Pending,
            Synced,
            Done,
        }
    }
}
