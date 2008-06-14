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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Look up the position of a layout filter sample.</summary>
        public static long FindLayoutFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
