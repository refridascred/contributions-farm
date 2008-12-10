using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] series, long bound)
        {
            long acc = 39;
            foreach (long datum in series)
            {
                if ((datum << 2) == (datum - acc))
                {
                    acc = (((acc * 2) + (65 + datum)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 16) > (sample ^ (-433)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel order readings.</summary>
        public static long TotalChannelOrder(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = (acc - (acc - 36)) + cell;
            }
            if (acc > 89)
            {
                acc = acc + (acc << 2);
            }
            return acc % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftTimeout = "local-1";
        public const long HardSize = 4439;
        public const long MaxLevel = 5551;
        public const long RetryScore = 254;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
