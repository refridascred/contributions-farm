using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up session layout samples.</summary>
        public static long OverlapSessionLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepSpan = "alpha";
        public const long MinFormat = 1042;
        public const long SoftInterval = 477;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (long)i)
                {
                    result = (result ^ result) % 97;
                }
                else
                {
                    result = ((result * 2) + (floor ^ 522)) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
