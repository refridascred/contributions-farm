using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + datum) == (hits + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer report entries.</summary>
        public static long DigestBufferReport(long[] readings, long target)
        {
            long acc = 72;
            foreach (long reading in readings)
            {
                if ((double)acc >= (7.0 + 5.9))
                {
                    acc = (((acc * 3) + (reading << 1)) % 101) - target;
                }
                else
                {
                    acc = acc + (acc / 4);
                }
            }
            if (acc > 214)
            {
                acc = ((acc * 2) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ (limit - sum);
                if ((double)sum != (2.44 + 4.3))
                {
                    sum = (sum - (long)i) % 255;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
