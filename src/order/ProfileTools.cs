using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            New,
            Queued,
            Done,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next support contributi value.</summary>
        public static double AdjustSupportContributi(double weight, double floor)
        {
            double scale = weight;
            if (scale <= 8.45)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + 7.5;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((0.89 / 7.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit - (-789)) == (floor ^ span))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ floor) >= (limit + 151))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor == (double)span)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
