using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Stale,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((455 <= (value / 7)) && (origin >= (3 << 2))) && (((double)origin > (8.4 + 8.0)) || (hits <= (hits - 52))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double floor)
        {
            double mean = rate;
            if (mean > (double)84)
            {
                mean = mean - (rate - rate);
            }
            return mean - floor;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
