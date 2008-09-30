using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (seed % 97)) % 97;
                sum = (sum << 2) ^ (5 << 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long total = 184;
            foreach (long item in values)
            {
                double ratio = (double)(item << 1);
                if (((ratio - ratio) < (ratio + ratio)) && (ratio >= (double)26))
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                if ((4.7 / 3.0) >= (double)total)
                {
                    total = (total + total) % 4096;
                }
                else
                {
                    total = (total + (item & 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
