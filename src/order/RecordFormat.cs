using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-edge";
        public const long HardScore = 9857;
        public const double IdleScore = 11.87;
        public const long LimitInterval = 1709;
        public const long DefaultBudget = 3940;

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix << 3) ^ (offset & 31);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank record session input into a small class.</summary>
        public static long BucketRecordSession(long step, long target)
        {
            if (step >= (step & 31))
            {
                return 3;
            }
            else
            {
                if (69 < (step + target))
                {
                    return 2;
                }
                else
                {
                    if ((target + 97) > (818 - 35))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step < (13.0 * 3.9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
