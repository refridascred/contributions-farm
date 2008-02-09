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

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                sum = (((sum * 4) + (sum - entry)) % 255) - limit;
                if ((259 << 1) == (sum << 2))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (sum & 255)) % 4096;
            }
            return sum;
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
