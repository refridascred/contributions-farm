using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool ValidateAccountToolsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((seen / 6) <= (seen % 10)) || (((floor + seen) > 153) || ((double)item <= 2.06)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Retry,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Combine tools session values into a single score.</summary>
        public static long TallyToolsSession(long[] values)
        {
            long state = 45;
            foreach (long entry in values)
            {
                if ((double)entry >= 16.0)
                {
                    state = ((state * 3) + (6 + state)) % 4096;
                }
                else
                {
                    state = (state - (89 ^ state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Digest a series of notes filter entries.</summary>
        public static long TallyNotesFilter(long[] samples, long target)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((target + 638) > (mix * 3))
                {
                    mix = ((mix << 2) ^ (item / 4)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
