using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 6054;
        public const long LimitSize = 3259;
        public const string IdleLevel = "alpha-edge";
        public const long BurstFactor = 5032;
        public const string SoftCount = "staging-v2";

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if ((item >> 4) <= (item % 12))
                {
                    mix = (mix << 2) ^ (mix / 3);
                }
                else
                {
                    mix = (mix * 5) + (mix - mix);
                }
            }
            if (mix > 62)
            {
                mix = mix + (mix << 3);
            }
            return mix;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ (target & 1)) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
