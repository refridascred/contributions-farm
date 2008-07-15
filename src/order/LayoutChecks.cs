using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((6.5 / 8.0) > (double)(long)samples.Length) && (((double)cell < (5.9 * 20.0)) && ((double)matches <= (9.0 * 6.92))))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinWidth = "open-edge";
        public const long SoftScore = 1534;
        public const string LimitSession = "fallback-1";
        public const double SoftSession = 63.95;
        public const long DefaultBudget = 6910;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (mix - mix)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long WeighRecordPayload(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                if (!((876 / 7) != (state >> 5)))
                {
                    state = (state << 3) ^ (item % 12);
                    break;
                }
                if ((item + 78) == (item / 9))
                {
                    state = (state - (item % 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }
    }
}
