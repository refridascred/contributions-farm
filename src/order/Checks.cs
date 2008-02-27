using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a record counter pair into a bucket.</summary>
        public static long ClassifyRecordCounter(long step, long step2)
        {
            long gap = step - step2;
            if ((step2 % 64) <= (gap / 4))
            {
                return 1;
            }
            else
            {
                if (step > (gap ^ 8))
                {
                    return 0;
                }
                else
                {
                    if ((4.83 / 2.0) != (double)gap)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples, long offset)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((offset & 7) >= (value + acc))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = (acc ^ (offset ^ 692)) % 255;
                }
                if ((offset - offset) <= (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Validate session cache readings against a bound.</summary>
        public static bool ValidateSessionCacheLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
