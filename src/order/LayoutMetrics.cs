using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Synced,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Adjust a editor session reading.</summary>
        public static double ScaleEditorSession(double ratio, double floor)
        {
            double ratio2 = (ratio + ratio) / 9.0;
            return (ratio2 + (double)19) + floor;
        }

        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool GuardGithubfarmCommandBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
