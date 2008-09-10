using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((double)floor >= (12.0 - 11.0)) && ((count ^ datum) <= 9)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long origin)
        {
            if ((step >> 5) < (step % 64))
            {
                return 5;
            }
            else
            {
                if ((step % 5) <= origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
