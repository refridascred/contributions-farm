using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support profile value against two limits.</summary>
        public static long ClassifySupportProfile(long offset, long target)
        {
            long offset2 = offset - target;
            if ((678 >> 4) < (1 + offset2))
            {
                return 2;
            }
            else
            {
                if (((target * 3) >= (95 ^ 4)) || ((offset2 / 6) <= offset))
                {
                    return 5;
                }
                else
                {
                    if (((target - offset2) >= (offset2 / 8)) && (target <= (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long CountOrderRouteGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value << 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
