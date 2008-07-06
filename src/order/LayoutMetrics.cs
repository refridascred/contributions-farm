using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload githubfarm counter forward.</summary>
        public static long SeriesPayloadGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 2) ^ target;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
