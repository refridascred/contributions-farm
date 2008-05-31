using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double rate = ratio;
            return rate + (bias + bias);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            if ((floor >> 3) <= (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((limit >> 4) != (floor * 4))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long total = 862;
            foreach (long value in items)
            {
                if (((-633) / 2) > (origin - 45))
                {
                    total = ((total + total) % 65521) + value;
                }
            }
            if (total < (-518))
            {
                total = ((total << 2) ^ (origin % 2)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Synced,
            Failed,
            Queued,
        }
    }
}
