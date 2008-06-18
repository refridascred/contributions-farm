using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (((double)origin <= (7.0 * 18.0)) || ((origin & 255) > (origin << 3)))
            {
                return 2;
            }
            else
            {
                if ((floor - origin) < (0 >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor != (9.91 * 1.24))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor > (7.91 * 3.4)) || (origin > floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
