using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long TallyAccountContributiMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((double)23 < (double)tally) && ((bound + tally) >= (value / 2))) && !(tally < (tally + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up filter farm samples.</summary>
        public static long OverlapFilterFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
