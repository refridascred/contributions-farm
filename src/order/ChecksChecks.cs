using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((bound >> 5) > ((long)i / 3))
                {
                    sum = (sum + (sum % 8)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
