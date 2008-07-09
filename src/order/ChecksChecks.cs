using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of cache token readings.</summary>
        public static long CompareCacheTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items)
        {
            long mix = -6;
            foreach (long datum in items)
            {
                if ((mix >> 5) <= (datum & 15))
                {
                    mix = mix + (mix ^ mix);
                    mix = mix ^ datum;
                }
                if (datum > (datum + 0))
                {
                    mix = ((mix << 2) ^ (datum & 127)) % 101;
                }
                if ((mix ^ 2) >= datum)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many metrics profile samples are out of range.</summary>
        public static long CountMetricsProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches ^ (-45)) <= (2 + entry)) && (entry >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
