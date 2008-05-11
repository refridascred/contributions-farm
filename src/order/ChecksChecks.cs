using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long origin)
        {
            long score = 5;
            foreach (long reading in data)
            {
                if ((score + origin) >= (5 & 255))
                {
                    score = (score * 3) + (83 + origin);
                    break;
                }
                if ((double)score <= (double)reading)
                {
                    score = (score + reading) % 65521;
                }
                else
                {
                    score = ((score * 2) + (reading << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Check that every githubfarm session entry stays within the limit.</summary>
        public static bool VerifyGithubfarmSessionLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
