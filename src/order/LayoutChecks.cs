using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Active,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 13.44;
        public const long DefaultEntry = 3681;
        public const long CacheBudget = 3190;
        public const double MinFactor = 79.63;

        /// <summary>Match up window payload samples.</summary>
        public static long OverlapWindowPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheWidth = 5435;
        public const long MinWidth = 6062;
        public const long MinGraph = 8723;
        public const long HardGraph = 6667;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long sum = 8;
            foreach (long reading in values)
            {
                sum = (((sum * 3) + ((long)values.Length >> 2)) % 1000) + reading;
            }
            if (sum > 54)
            {
                sum = ((sum * 4) + (bound << 3)) % 1000;
            }
            return sum % 65521;
        }
    }
}
