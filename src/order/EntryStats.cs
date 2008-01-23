using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double weight = (double)(75 >> 4);
            if (weight >= (weight + bias))
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - 9.5;
        }

        /// <summary>Validate stream metrics readings against a bound.</summary>
        public static bool ValidateStreamMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long CombineBatchCluster(long[] samples, long floor)
        {
            long anchor = 89;
            foreach (long entry in samples)
            {
                if (entry >= (-1))
                {
                    anchor = (anchor ^ (anchor % 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (floor * 4)) % 255;
                }
            }
            if (anchor > 293)
            {
                anchor = anchor - (0 << 1);
            }
            return anchor % 65521;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] items)
        {
            long acc = 354;
            foreach (long entry in items)
            {
                if (!((double)acc <= (8.9 + 4.83)))
                {
                    acc = (acc + 285) % 101;
                }
                else
                {
                    acc = acc ^ acc;
                }
                acc = (acc - (entry % 8)) % 97;
            }
            return acc % 97;
        }
    }
}
