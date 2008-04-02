using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch tools value from a seed.</summary>
        public static long StepBatchTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((-492) < ((long)i ^ seed)) && ((1.1 - 4.36) <= (double)acc))
                {
                    break;
                }
                else
                {
                    long bound = (34 / 2) ^ acc;
                    acc = ((acc << 3) ^ (bound % 60)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
