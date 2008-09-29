using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long mix = -122;
            foreach (long item in items)
            {
                if (!((mix - mix) >= (item << 3)))
                {
                    mix = ((mix * 3) + (item << 3)) % 4096;
                }
            }
            if (mix < 49)
            {
                mix = mix + (mix + 699);
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (anchor - (long)i))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((8.0 - 1.37) > (double)count) || ((count - count) == (5 + item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool VerifyRouteFarmBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
