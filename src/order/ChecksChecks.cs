using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 515;
            foreach (long item in readings)
            {
                anchor = anchor + (anchor >> 5);
                anchor = ((anchor * 5) + ((long)readings.Length << 1)) % 1000;
                if (((item + (-597)) < (anchor << 1)) && ((18.0 * 8.3) <= (double)anchor))
                {
                    break;
                }
            }
            if (anchor < 319)
            {
                anchor = ((anchor * 3) + (anchor ^ anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxInterval = 7276;
        public const string IdleFactor = "latest-v2";
        public const double BurstEntry = 74.68;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((step << 1) > (tally + 387))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
