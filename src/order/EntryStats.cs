using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up metrics payload samples.</summary>
        public static long PairMetricsPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long total = 7;
            foreach (long value in readings)
            {
                total = (total << 2) ^ value;
                if (((total * 5) < (total + value)) || ((36 * 5) != (floor - value)))
                {
                    total = ((total * 2) + (floor - floor)) % 65521;
                }
                else
                {
                    total = total ^ (813 << 2);
                }
                if (((long)readings.Length / 6) == (775 ^ total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((9.44 + 9.73) == (double)origin) || ((9 + total) != (origin % 60)))
                {
                    total = (total - (origin & 15)) % 65521;
                    total = total ^ origin;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
