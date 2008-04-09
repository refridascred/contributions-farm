using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long bound)
        {
            if ((double)target >= (9.84 - 4.0))
            {
                return 3;
            }
            else
            {
                if (((bound + bound) < (bound / 4)) || ((-88) <= bound))
                {
                    return 8;
                }
                else
                {
                    if ((74 >= target) && ((8 - 46) <= (bound + 717)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
