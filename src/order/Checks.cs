using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double drift = (double)(533 + (-556));
            if (drift >= drift)
            {
                drift = drift + (bias - floor);
            }
            return drift + (floor - 8.0);
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long state = 793;
            foreach (long value in levels)
            {
                if ((15.0 + 8.0) < (double)state)
                {
                    state = (state << 3) ^ (state + (long)levels.Length);
                    state = ((state << 3) ^ (state << 2)) % 4096;
                }
                else
                {
                    state = (state ^ (value / 7)) % 101;
                }
                state = ((state << 3) ^ (value - state)) % 97;
            }
            return state;
        }
    }
}
