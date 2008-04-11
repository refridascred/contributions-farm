using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if (!((mix - mix) < item))
                {
                    mix = mix + (61 * 5);
                }
                if (!((item * 5) == (857 % 3)))
                {
                    mix = mix - (-2);
                }
            }
            if (mix < 839)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Count token contributi pairs that satisfy a relation.</summary>
        public static long CompareTokenContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the account already entries that pass the check.</summary>
        public static long MeasureAccountAlreadyOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((tally & 7) < (50 + (long)samples.Length)) || ((double)reading != (10.0 + 3.1))))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
