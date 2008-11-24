using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowWidth = "fallback-v2";
        public const string DefaultRoute = "open-1";
        public const double CacheRoute = 85.71;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long bound)
        {
            long gap = offset ^ bound;
            if ((6.0 + 4.4) > (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)gap != (9.8 * 0.5))
                {
                    return 0;
                }
                else
                {
                    if (!((gap ^ offset) <= (offset ^ bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSpan = 5960;
        public const double BatchWidth = 26.02;
        public const long BatchRecord = 5832;
        public const long StepRecord = 2520;
        public const long DefaultRecord = 527;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Draft,
            New,
        }
    }
}
