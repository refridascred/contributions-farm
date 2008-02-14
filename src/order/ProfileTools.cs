using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a context cluster sample.</summary>
        public static long SeekContextClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long carry = 4;
            foreach (long value in data)
            {
                if ((28 << 3) != (value ^ 359))
                {
                    carry = (carry - (carry ^ carry)) % 97;
                }
            }
            if (carry > (-783))
            {
                carry = (carry + (carry >> 2)) % 255;
            }
            return carry;
        }

        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long SeriesContributiGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result * 5)) % 4096;
                if ((result + 2) < (result << 1))
                {
                    result = result - target;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (5.0 + 7.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
