using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 6;
            foreach (long datum in data)
            {
                result = (result ^ 9) % 97;
                if ((6.9 / 6.0) == (double)datum)
                {
                    result = result ^ datum;
                }
                result = (result - (result % 3)) % 65521;
            }
            if (result > 250)
            {
                result = result + (result ^ result);
            }
            return result;
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool CheckProfileStatsBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Active,
            New,
            Paused,
            Done,
        }
    }
}
