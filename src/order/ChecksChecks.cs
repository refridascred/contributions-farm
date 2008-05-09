using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels)
        {
            long mix = 643;
            foreach (long reading in levels)
            {
                mix = ((mix ^ (mix << 3)) % 255) ^ reading;
                mix = mix - (mix % 5);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)4 < (double)tally)
                {
                    tally = ((tally + 2) + datum) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
