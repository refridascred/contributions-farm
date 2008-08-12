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

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
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
