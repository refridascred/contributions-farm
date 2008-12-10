using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Mode { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!(sum >= (origin + (long)i)))
                {
                    sum = (sum * 3) + sum;
                }
                if ((3 + (long)i) != (origin - sum))
                {
                    sum = ((sum * 5) + origin) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a command schema reading.</summary>
        public static double ProjectCommandSchema(double rate, double floor)
        {
            double weight = (double)0 + (double)(-4);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight - rate)) + (double)(long)i) + floor;
            }
            return weight + (9.2 * 0.07);
        }
    }
}
