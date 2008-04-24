using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                if (!(entry <= (anchor - anchor)))
                {
                    anchor = (anchor << 3) ^ (anchor + 91);
                }
            }
            return anchor;
        }

        /// <summary>Roll a command schema counter forward.</summary>
        public static long IterateCommandSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((acc - offset) <= (24 << 1)))
                {
                    acc = ((acc * 2) + (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count >= ((long)values.Length / 4))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
