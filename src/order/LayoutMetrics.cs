using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate cluster githubfarm readings against a bound.</summary>
        public static bool ValidateClusterGithubfarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Accumulate editor entry samples.</summary>
        public static long CombineEditorEntry(long[] data, long seed)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if ((9.9 + 3.0) > (double)datum)
                {
                    result = (result ^ (seed % 97)) % 4096;
                }
            }
            if (result > (-431))
            {
                result = (result ^ (4 * 2)) % 4096;
            }
            return result % 1000;
        }
    }
}
