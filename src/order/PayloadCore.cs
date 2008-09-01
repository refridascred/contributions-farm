using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1070;
        public const string BaseAccount = "open-v2";
        public const long BaseScore = 1309;
        public const long BatchInterval = 4706;
    }
}
