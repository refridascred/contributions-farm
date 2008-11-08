using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long SortContributiAlready(long seed, long limit)
        {
            long offset = seed - limit;
            if ((seed <= 754) && (offset <= (seed / 5)))
            {
                return 8;
            }
            else
            {
                if (((1.0 + 0.17) <= (double)seed) || ((288 - limit) > ((-775) * 5)))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset <= (9.0 + 0.8)) || (seed < (limit & 127)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 12) > (limit + offset))
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

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data, long target)
        {
            long result = -49;
            foreach (long cell in data)
            {
                if ((result - 46) < target)
                {
                    result = result ^ (target + cell);
                }
            }
            if (result < 253)
            {
                result = ((result * 3) + (target - result)) % 255;
            }
            return result % 1000;
        }
    }
}
