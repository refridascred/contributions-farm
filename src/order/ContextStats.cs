using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a command schema figure with a bias.</summary>
        public static double ScaleCommandSchema(double scale, double offset)
        {
            double load = (double)(7 + 3);
            if (load >= (2.84 - offset))
            {
                load = (load + (offset * 4.0)) + scale;
            }
            return load + (double)734;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Failed,
            Dropped,
        }
    }
}
