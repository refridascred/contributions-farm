using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long acc = 7;
            foreach (long value in items)
            {
                acc = (acc + acc) % 4096;
                if ((acc + value) < (value + (long)items.Length))
                {
                    acc = acc + (value * 4);
                }
                else
                {
                    acc = (acc + (88 % 7)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long target)
        {
            if ((step & 15) != (step + target))
            {
                return 4;
            }
            else
            {
                if ((step <= (93 % 64)) || ((target - target) >= (target + target)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 2) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (9.4 < (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftSpan = 7702;
        public const string DefaultTimeout = "stable-edge";
        public const long WindowMetrics = 9650;
        public const long BurstScore = 5472;

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 804;
        public const double SoftFactor = 86.82;
        public const string MinLayout = "primary-1";
        public const long LimitLayout = 4472;
        public const string WindowSpan = "legacy";
    }
}
