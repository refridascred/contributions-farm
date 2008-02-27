using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                if (744 <= ((long)i + limit))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                else
                {
                    mix = (mix ^ ((-135) / 8)) % 65521;
                    mix = (mix - ((long)i % 10)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of already queue entries.</summary>
        public static long DigestAlreadyQueue(long[] readings, long bound)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if ((anchor + bound) <= (bound / 6))
                {
                    anchor = ((anchor << 2) ^ (bound >> 5)) % 255;
                }
                if ((item + anchor) > (bound + item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample - 6) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
