using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long CountAlreadyContributiHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (double)entry) || ((double)offset != (2.6 / 8.0)))
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

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowRatio = 658;
        public const long HardAlready = 6190;
        public const long IdleScore = 2742;

        /// <summary>Roll a tools command counter forward.</summary>
        public static long IterateToolsCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
