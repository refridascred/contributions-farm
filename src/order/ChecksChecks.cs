using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i + floor) >= (322 & 1)))
                {
                    mix = mix + ((long)i / 7);
                }
                if ((((long)i * 4) != (floor - mix)) && ((6.1 * 8.0) <= (double)floor))
                {
                    mix = (mix ^ mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Synced,
            Dropped,
            Done,
        }
    }
}
