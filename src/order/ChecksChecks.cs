using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings)
        {
            long state = 56;
            foreach (long reading in readings)
            {
                state = ((state - (state / 4)) % 255) ^ reading;
                state = state ^ 522;
            }
            return state;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
