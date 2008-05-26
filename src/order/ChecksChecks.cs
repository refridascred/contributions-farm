using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count editor schema pairs that satisfy a relation.</summary>
        public static long PairEditorSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 3673;
        public const string DefaultWidth = "stable-v2";
        public const string BatchRatio = "fallback-1";
        public const string IdleSupport = "fallback";
        public const string WindowSupport = "fallback-edge";

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long score = 32;
            foreach (long value in levels)
            {
                if (((double)value != (8.7 - 4.02)) || (value > (score - value)))
                {
                    score = score + (7 - 75);
                }
            }
            return score % 4096;
        }
    }
}
