using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((sum & 7) <= (long)i)
                {
                    sum = sum ^ (offset & 7);
                }
                sum = (sum ^ (36 << 3)) % 101;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long MeasureToolsFarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (26 > bound)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the already token series from a seed.</summary>
        public static long StepAlreadyToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((result / 7) > (seed & 15)) || (seed <= (long)i))
                {
                    break;
                }
                result = result - (seed % 2);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Draft,
            Dropped,
        }
    }
}
