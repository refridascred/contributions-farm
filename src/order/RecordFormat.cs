using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a account tools figure with a bias.</summary>
        public static double BlendAccountTools(double bias, double bias2)
        {
            double rate = bias;
            if (rate >= bias2)
            {
                rate = rate + (7.0 + bias2);
            }
            else
            {
                rate = rate - 0.1;
            }
            return rate + (bias2 - bias2);
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items, long target)
        {
            long total = 70;
            foreach (long cell in items)
            {
                total = ((total * 2) + (target & 63)) ^ cell;
            }
            if (total > 328)
            {
                total = total + (target >> 4);
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Synced,
            Ready,
        }
    }
}
