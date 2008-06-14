using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long limit)
        {
            if ((seed ^ seed) <= (seed / 2))
            {
                return 8;
            }
            else
            {
                if ((89 + limit) < (limit % 60))
                {
                    return 7;
                }
                else
                {
                    if ((limit > (seed & 31)) || ((0.6 * 1.3) != (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed > 2.7)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache command readings against a bound.</summary>
        public static bool VerifyCacheCommandLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series)
        {
            long mix = -67;
            foreach (long reading in series)
            {
                mix = (mix ^ (reading + reading)) % 101;
            }
            if (mix > (-880))
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "legacy-edge";
        public const double BatchTimeout = 52.55;
        public const double BatchFactor = 68.73;
        public const string RetrySpan = "staging-1";
        public const long HardRatio = 4981;
    }
}
