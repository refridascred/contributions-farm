using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long result = 299;
            foreach (long entry in readings)
            {
                if ((entry <= (174 + 6)) && ((0.23 - 15.0) <= (double)result))
                {
                    result = result ^ (entry << 2);
                }
            }
            if (result < (-799))
            {
                result = (result * 5) + (352 & 7);
            }
            return result % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ (state << 2)) % 4096) ^ (long)i2;
                    state = ((state << 3) ^ state) % 1000;
                }
                state = ((state * 5) + origin) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a notes entry sample.</summary>
        public static long SeekNotesEntryIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
