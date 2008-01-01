using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings)
        {
            long mix = 3;
            foreach (long datum in readings)
            {
                if ((mix < datum) && (10 <= (datum % 8)))
                {
                    mix = ((mix << 2) ^ (long)readings.Length) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] data)
        {
            long anchor = 78;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ (anchor % 3)) % 101;
                if (!((31 + item) < anchor))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 3) ^ 3) % 65521;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 7504;
        public const long WindowEntry = 7482;
        public const double BurstSpan = 12.3;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item + 4) > matches) || (item > (59 + matches))) && ((8 >= item) && (matches <= (item & 3))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
