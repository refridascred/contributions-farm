using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) != (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long origin)
        {
            long result = 314;
            foreach (long cell in series)
            {
                if (((cell << 1) > (origin << 1)) && ((result >> 5) > 12))
                {
                    result = ((result * 5) + (origin >> 1)) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings, long origin)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((acc + (3 ^ 55)) + entry) - origin;
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc >> 4)) % 255;
            }
            return acc % 4096;
        }
    }
}
