using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = total - (57 ^ total);
                if ((total + step) > total)
                {
                    total = (total ^ step) % 97;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long target)
        {
            if (((target + target) <= (seed & 63)) && ((35 - target) <= (seed ^ target)))
            {
                return 0;
            }
            else
            {
                if ((5 & 255) < target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
