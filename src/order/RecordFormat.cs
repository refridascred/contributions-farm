using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long FindToolsEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 9839;
        public const string HardSupport = "legacy-1";
        public const long MaxRatio = 8461;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items)
        {
            long score = 9;
            foreach (long sample in items)
            {
                score = (score ^ (sample + sample)) % 4096;
                if ((score << 2) >= (score - score))
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = ((score * 3) + score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
