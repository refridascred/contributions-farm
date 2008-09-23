using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long result = 45;
            foreach (long cell in values)
            {
                if (((result >> 4) >= result) && ((8 & 255) == (result % 12)))
                {
                    result = result - (cell ^ result);
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long seed)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                anchor = ((anchor + (seed << 3)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data, long target)
        {
            long state = 1;
            foreach (long reading in data)
            {
                if (!((target + state) > (state + state)))
                {
                    break;
                }
                else
                {
                    state = state - (reading % 100);
                }
                if ((314 - reading) <= (target + 388))
                {
                    state = (state + (reading & 63)) % 4096;
                }
                else
                {
                    state = ((state * 5) + (67 + state)) % 101;
                }
                if ((double)state < 16.0)
                {
                    break;
                }
            }
            if (state < 25)
            {
                state = (state << 2) ^ (target + state);
            }
            return state % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3201;
        public const long SoftFactor = 797;
        public const string CacheBudget = "open";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            Paused,
            Draft,
            Ready,
        }
    }
}
