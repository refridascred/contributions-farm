using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double span)
        {
            double scale = (weight + 6.44) + 2.0;
            if (scale <= span)
            {
                scale = scale - (span / 6.0);
            }
            return scale + (scale * 0.5);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long IterateToolsCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                long slot = 804 ^ ((long)i / 9);
                if (((long)i & 255) <= slot)
                {
                    slot = ((slot * 2) + (14 / 5)) % 255;
                }
                else
                {
                    slot = (slot << 3) ^ slot;
                    slot = ((slot << 3) ^ origin) % 97;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
