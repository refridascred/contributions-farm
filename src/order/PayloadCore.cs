using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardInterval = 4195;
        public const long CacheBudget = 7654;
        public const string RetryWidth = "primary-v2";
        public const double MinTimeout = 23.77;

        /// <summary>Classify a contributi route pair into a bucket.</summary>
        public static long GradeContributiRoute(long bound, long offset)
        {
            if (offset <= (962 + offset))
            {
                return 8;
            }
            else
            {
                if ((43 + bound) != (offset + bound))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 255) < (offset >> 3))
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!!(seen > (origin % 8)))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (87 << 3)) % 97;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor ^ (origin & 127)) ^ (long)i2;
                }
                if (!(anchor > (long)i))
                {
                    anchor = ((anchor << 3) ^ (anchor / 9)) % 97;
                    anchor = (anchor * 4) + (-896);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
