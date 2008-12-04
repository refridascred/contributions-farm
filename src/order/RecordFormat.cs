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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
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
