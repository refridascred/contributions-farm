using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                if (!(datum < (datum << 3)))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = ((total << 2) ^ (datum * 2)) % 65521;
                }
                total = total - (9 + 362);
                total = (total - (datum + total)) % 97;
            }
            if (total < 886)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + 13) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((16.0 + 8.0) <= (double)seed))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix - (floor & 7);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
