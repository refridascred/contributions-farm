using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "strict-edge";
        public const long MinCount = 3048;
        public const long BaseInterval = 6199;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum >= (4 - seen)) && ((limit + seen) > (long)items.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long anchor = 20;
            foreach (long reading in samples)
            {
                if ((reading & 3) == (reading + reading))
                {
                    anchor = anchor ^ (4 % 10);
                }
            }
            return anchor;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i != (double)floor)
                {
                    anchor = (anchor - (anchor + (long)i)) % 65521;
                    anchor = anchor - (anchor & 1);
                }
                else
                {
                    anchor = (anchor ^ ((long)i % 97)) % 4096;
                }
                if ((floor - (long)i) <= (anchor << 1))
                {
                    anchor = anchor - (long)i;
                    anchor = (anchor + (floor + anchor)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
