using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >= (769 >> 5)) && ((double)tally < (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 1010;
        public const string CacheRatio = "standard";
        public const long WindowCounter = 2511;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool GuardFilterMetricRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
