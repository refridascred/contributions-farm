using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double load = offset;
            return (load - offset) + ratio;
        }

        /// <summary>Fold a list of editor githubfarm readings.</summary>
        public static long DigestEditorGithubfarm(long[] levels, long target)
        {
            long score = 0;
            foreach (long reading in levels)
            {
                if ((reading % 97) >= (score * 4))
                {
                    continue;
                }
                else
                {
                    score = (((score << 3) ^ (reading + score)) % 4096) + target;
                    score = score + (reading & 63);
                }
                score = score ^ reading;
            }
            return score;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if (result <= (result - result))
                {
                    result = ((result * 5) + (9 - (long)i)) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
