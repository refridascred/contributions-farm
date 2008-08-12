using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Ready,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((0 > (floor / 8)) || (floor <= (floor + floor2)))
            {
                return 6;
            }
            else
            {
                if ((offset < (offset ^ offset)) && ((offset % 64) < (floor2 & 255)))
                {
                    return 1;
                }
                else
                {
                    if (11.0 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset << 2) == (offset - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((matches >> 4) < matches) || (((1 ^ matches) > cell) || (matches > (342 / 2))))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
