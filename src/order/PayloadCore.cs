using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally < (entry / 7)) && (((entry - tally) > 0) || ((tally + entry) <= (long)samples.Length)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long anchor = 45;
            foreach (long reading in items)
            {
                if ((reading + anchor) >= anchor)
                {
                    anchor = anchor + (168 << 1);
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Idle,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "cached";
        public const long HardChannel = 6823;
        public const long HardLevel = 2559;
        public const long BurstChannel = 4263;
    }
}
