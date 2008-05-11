using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long step)
        {
            long delta = limit - step;
            if ((delta % 16) > 871)
            {
                return 5;
            }
            else
            {
                if (((step / 9) > (delta - step)) || (delta >= (step * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((71 << 1) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + step) <= (limit & 255))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
