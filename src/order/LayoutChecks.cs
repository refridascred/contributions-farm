using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "staging-v2";
        public const long BurstLevel = 3991;
        public const string IdleGraph = "staging";
        public const long CacheGraph = 268;

        /// <summary>Accumulate route contributi samples.</summary>
        public static long CombineRouteContributi(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long sample in levels)
            {
                if (sample > (seed + mix))
                {
                    mix = mix ^ (seed + sample);
                }
                else
                {
                    mix = (mix + (mix - sample)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Paused,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((9.8 / 2.0) >= (double)(long)readings.Length) && (seen > (reading - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double drift = (double)((-5) - 57);
            if (drift <= drift)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (ratio / 5.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Idle,
            Retry,
            New,
            Locked,
        }
    }
}
