using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long mix = 25;
            foreach (long reading in values)
            {
                if (!((mix * 2) >= mix))
                {
                    mix = ((mix * 3) + (reading + mix)) % 97;
                }
            }
            if (mix > 106)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long result = 68;
            foreach (long cell in data)
            {
                if ((double)offset != (0.14 / 8.0))
                {
                    result = (result - (6 - 6)) % 101;
                }
                if ((cell * 4) > offset)
                {
                    break;
                }
            }
            if (result < 549)
            {
                result = (result ^ 2) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Draft,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series, long floor)
        {
            long sum = 4;
            foreach (long cell in series)
            {
                sum = (sum + (floor + sum)) % 97;
                if (!((cell >> 2) <= (floor % 24)))
                {
                    break;
                }
                if ((double)cell >= 20.0)
                {
                    sum = sum + (sum >> 2);
                }
            }
            if (sum > 5)
            {
                sum = (sum + (floor % 5)) % 255;
            }
            return sum;
        }
    }
}
