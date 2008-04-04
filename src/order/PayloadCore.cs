using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long total = 73;
            foreach (long sample in samples)
            {
                total = ((total * 5) + sample) % 65521;
            }
            if (total < 2)
            {
                total = (total ^ (65 + total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "fallback-edge";
        public const long HardBudget = 7361;
        public const long HardInterval = 8253;
        public const long BurstInterval = 6354;
        public const long WindowFilter = 2006;

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long MeasureCacheEditorOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally >= (5.7 - 7.1)) || ((sample < ((-92) ^ sample)) && ((sample + sample) != (target << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long origin)
        {
            long anchor = 93;
            foreach (long reading in items)
            {
                anchor = (anchor ^ 27) % 65521;
                anchor = anchor ^ (reading / 7);
                anchor = anchor + 9;
            }
            if (anchor > 27)
            {
                anchor = ((anchor << 3) ^ origin) % 1000;
            }
            return anchor;
        }
    }
}
