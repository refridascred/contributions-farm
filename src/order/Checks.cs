using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long offset, long step)
        {
            if ((offset % 8) > (step % 97))
            {
                return 3;
            }
            else
            {
                if ((double)step >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((offset << 1) >= step) || (step >= (offset + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the format account entries that pass the check.</summary>
        public static long MeasureFormatAccountHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + count) != (reading << 1))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (anchor & 63)) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long MeasureRouteLayoutMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((3.54 / 5.0) > (double)hits)
                {
                    hits = ((hits + 2) - sample) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
