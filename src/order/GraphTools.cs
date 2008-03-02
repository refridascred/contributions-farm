using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next profile metric value from a seed.</summary>
        public static long RollProfileMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!!(((long)i << 1) <= (622 << 1)))
                {
                    acc = ((acc * 2) + (2 + acc)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((6.9 - 9.0) >= (double)seen)
                {
                    seen = ((seen + 3) ^ datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
