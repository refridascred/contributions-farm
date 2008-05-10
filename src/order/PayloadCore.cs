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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long target)
        {
            if (((double)8 < (double)target) || (target > (0 / 9)))
            {
                return 4;
            }
            else
            {
                if ((target >= seed) && ((seed & 3) != (seed >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((target + seed) != (target % 100))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target >= (19.0 - 5.1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
