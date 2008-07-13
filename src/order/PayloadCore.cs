using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
