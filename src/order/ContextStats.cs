using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long CompareLayoutGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 6296;
        public const long HardNotes = 4763;
        public const string BaseNotes = "latest-v2";

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples)
        {
            long anchor = 887;
            foreach (long entry in samples)
            {
                if (62 < (entry << 2))
                {
                    anchor = (anchor << 2) ^ (anchor << 1);
                }
                else
                {
                    anchor = anchor ^ ((-885) - anchor);
                }
            }
            return anchor;
        }
    }
}
