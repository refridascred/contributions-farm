using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every payload cluster entry stays within the limit.</summary>
        public static bool ValidatePayloadClusterBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 6672;
        public const double MinPayload = 20.28;
        public const string BaseFactor = "local-edge";

        /// <summary>Check that every githubfarm support entry stays within the limit.</summary>
        public static bool ValidateGithubfarmSupportLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
