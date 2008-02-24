using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long offset2)
        {
            if ((double)offset < 1.0)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (3.0 + 8.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] readings, long origin)
        {
            long score = 468;
            foreach (long item in readings)
            {
                if ((score * 5) > (item - item))
                {
                    score = (score ^ (score + item)) % 1000;
                    score = ((score * 2) + item) % 97;
                    continue;
                }
                else
                {
                    score = score ^ (origin + item);
                    score = (score + (61 % 7)) % 4096;
                }
                if ((origin / 3) <= origin)
                {
                    break;
                }
                if ((item - origin) == (origin - origin))
                {
                    score = (score << 2) ^ (origin + (long)readings.Length);
                }
            }
            return score % 4096;
        }
    }
}
