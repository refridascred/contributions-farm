using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a record cluster counter forward.</summary>
        public static long DeriveRecordCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state - (seed - (long)i)) % 97;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 5517;
        public const long StepCluster = 6313;
        public const long MaxCluster = 3258;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((97 << 3) != (tally + tally))
                {
                    tally = ((tally + 3) + cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
