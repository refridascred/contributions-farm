using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of command account readings.</summary>
        public static long FoldCommandAccount(long[] levels)
        {
            long state = 856;
            foreach (long value in levels)
            {
                state = ((state * 5) + (362 << 3)) + value;
            }
            return state % 65521;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long MatchLayoutGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
