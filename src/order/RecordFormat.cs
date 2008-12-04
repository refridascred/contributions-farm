using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate editor cluster samples.</summary>
        public static long TotalEditorCluster(long[] items)
        {
            long mix = 77;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    long seen = mix;
                    mix = (mix + (seen + value)) ^ (long)i;
                }
                mix = (mix + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples, long bound)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                if ((entry % 16) >= (entry + score))
                {
                    score = (score ^ (274 & 127)) % 1000;
                }
                if ((bound + bound) < (entry + bound))
                {
                    score = (score - (entry + bound)) % 1000;
                }
                else
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Pending,
            Ready,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report channel measurements.</summary>
        public static double ProjectReportChannel(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - drift) + floor;
        }
    }
}
