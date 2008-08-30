using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first metrics stream entry that matches the target.</summary>
        public static long SeekMetricsStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "staging-edge";
        public const string BurstReport = "stable-1";
        public const long StepReport = 8181;
        public const double CacheCount = 91.22;
        public const double DefaultReport = 0.95;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9214;
        public const string MaxReport = "staging-v2";
        public const long MinTimeout = 6778;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of editor graph readings.</summary>
        public static long TallyEditorGraph(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((result + reading) >= (661 + result))
                {
                    result = result - (reading - result);
                }
            }
            if (result > 94)
            {
                result = ((result << 3) ^ (result ^ result)) % 1000;
            }
            return result % 4096;
        }
    }
}
