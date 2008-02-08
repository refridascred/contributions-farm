using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels)
        {
            long anchor = 53;
            foreach (long datum in levels)
            {
                anchor = (anchor - (datum - anchor)) % 65521;
            }
            if (anchor > 64)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                if (score > floor)
                {
                    score = score - (long)i;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 63.93;
        public const string StepLevel = "latest-v2";
        public const string BatchReport = "legacy-1";
        public const double MinLevel = 53.98;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
