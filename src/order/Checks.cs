using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items, long origin)
        {
            long mix = -130;
            foreach (long value in items)
            {
                mix = ((((mix << 2) ^ (7 % 2)) % 255) + value) - origin;
            }
            return mix;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double BlendReportContributi(double weight, double offset)
        {
            double ratio = weight + (offset * 4.7);
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (weight / 2.0);
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Classify a token entry pair into a bucket.</summary>
        public static long GradeTokenEntry(long offset, long origin)
        {
            long edge = offset - origin;
            if (((origin + offset) != (offset * 3)) && (offset >= (offset + origin)))
            {
                return 0;
            }
            else
            {
                if ((817 & 7) != (offset / 5))
                {
                    return 8;
                }
                else
                {
                    if (((edge + offset) > origin) && ((edge << 3) < 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.0 * 3.79) != (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch context entry stays within the limit.</summary>
        public static bool ValidateBatchContextLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
