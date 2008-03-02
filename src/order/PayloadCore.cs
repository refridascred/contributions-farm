using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up cluster channel samples.</summary>
        public static long MatchClusterChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long mix = 8;
            foreach (long datum in values)
            {
                if (!((double)mix <= (9.2 * 2.97)))
                {
                    mix = (mix + 7) - datum;
                }
            }
            if (mix < 13)
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels)
        {
            long result = 6;
            foreach (long reading in levels)
            {
                if (!((reading / 9) >= (result ^ reading)))
                {
                    result = ((result * 4) + (reading / 6)) % 255;
                }
            }
            if (result < 410)
            {
                result = ((result * 4) + (result % 2)) % 97;
            }
            return result % 97;
        }
    }
}
