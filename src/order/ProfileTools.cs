using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema layout value from a seed.</summary>
        public static long RollSchemaLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = result - result;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long seed)
        {
            long prev = origin - seed;
            if (((-87) < origin) && ((double)origin >= 3.63))
            {
                return 5;
            }
            else
            {
                if (((2 + seed) < seed) && (seed <= (origin - prev)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)prev <= (5.47 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed > (9.0 * 1.98))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
