using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long bound2)
        {
            long diff = bound ^ bound2;
            if (!((bound % 8) <= (545 ^ bound2)))
            {
                return 6;
            }
            else
            {
                if ((diff - diff) >= bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples)
        {
            long acc = 351;
            foreach (long cell in samples)
            {
                acc = (acc - (cell - cell)) % 65521;
            }
            if (acc < 577)
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }
    }
}
