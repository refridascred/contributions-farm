using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
