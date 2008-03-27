using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Done,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (1.4 >= (double)offset)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
