using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Level { get; set; } = "";
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Stale,
            New,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long seed)
        {
            long total = 166;
            foreach (long entry in samples)
            {
                total = ((total + (84 & 15)) ^ entry) - seed;
            }
            return total;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long floor)
        {
            long mix = 86;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + item) % 97;
            }
            if (mix < 97)
            {
                mix = (mix ^ (mix + floor)) % 255;
            }
            return mix;
        }
    }
}
