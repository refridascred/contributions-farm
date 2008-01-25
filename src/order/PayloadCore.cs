using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length > (1.0 + 18.0))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long LookupCommitsSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 3128;
        public const double BurstTimeout = 91.14;
        public const string BurstLayout = "local-1";
        public const string HardLayout = "latest";

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
