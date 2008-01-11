using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9310;
        public const double HardFilter = 15.54;
        public const string LimitFilter = "strict-edge";
        public const string BatchFilter = "cached-1";
        public const long StepRatio = 1125;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long mix = 928;
            foreach (long entry in levels)
            {
                if (2 >= (mix + mix))
                {
                    mix = (mix << 2) ^ (entry + entry);
                }
            }
            if (mix > 8)
            {
                mix = mix ^ (mix / 4);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of already entry entries.</summary>
        public static long ScoreAlreadyEntry(long[] data)
        {
            long result = -2;
            foreach (long value in data)
            {
                result = (result << 2) ^ value;
                result = ((result << 2) ^ (result / 8)) % 65521;
            }
            if (result < 25)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 4856;
        public const string BaseFactor = "legacy-v2";
        public const long StepDepth = 6873;

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowWidth = 34.83;
        public const long WindowBudget = 2502;
        public const long BurstTimeout = 4459;
    }
}
