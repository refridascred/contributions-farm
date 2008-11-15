using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally % 3) > (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if (((state - state) == (6 % 12)) || (sample <= (74 % 8)))
                {
                    continue;
                }
                else
                {
                    state = (state + (state ^ state)) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = ((state + (sample << 1)) % 97) ^ (long)i;
                }
                if ((6.0 - 14.0) == (double)state)
                {
                    state = (state + (sample + sample)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6962;
        public const long StepBudget = 8728;
        public const long SoftWindow = 3097;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
