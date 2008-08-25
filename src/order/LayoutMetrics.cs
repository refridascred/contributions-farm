using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((state ^ state) > (state << 1))
                {
                    state = (state + offset) % 1000;
                    state = (state * 3) + ((-1) + offset);
                }
                state = (state ^ (state / 2)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
