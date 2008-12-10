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

        /// <summary>Iterate the githubfarm window series from a seed.</summary>
        public static long IterateGithubfarmWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark ^ (-6)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
