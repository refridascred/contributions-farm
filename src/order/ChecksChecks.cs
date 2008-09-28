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

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values, long origin)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if ((origin * 4) <= (result / 9))
                {
                    result = (result * 5) + (reading - reading);
                }
                result = result + (reading ^ (-21));
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
