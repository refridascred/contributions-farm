using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool CheckGithubfarmBatchesBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchRatio = 43.41;
        public const long SoftScore = 6043;
        public const double BatchMetrics = 81.73;
        public const double RetryRatio = 62.3;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long target)
        {
            long slot = origin + target;
            if ((origin < (target * 3)) || ((6.0 / 3.0) <= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((slot - slot) != ((-3) % 12))
                {
                    return 6;
                }
                else
                {
                    if ((target + target) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long mark = 50;
            foreach (long reading in levels)
            {
                if (!((-1) >= (90 + reading)))
                {
                    mark = (mark - (reading - (-787))) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ (reading + 1);
                }
                if ((reading < (reading << 2)) || ((reading * 2) > (mark * 3)))
                {
                    mark = (mark - (mark + reading)) % 4096;
                }
                if ((reading + mark) < (reading - mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
