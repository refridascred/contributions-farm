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

        /// <summary>Classify a githubfarm report pair into a bucket.</summary>
        public static long BucketGithubfarmReport(long origin, long limit)
        {
            long bound = origin ^ limit;
            if (!((bound & 63) == (origin % 8)))
            {
                return 3;
            }
            else
            {
                if ((origin + limit) != (73 / 5))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 5) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((950 + origin) < bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
