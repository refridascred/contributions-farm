using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Queued,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings)
        {
            long result = 69;
            foreach (long datum in readings)
            {
                result = ((result + result) % 97) + datum;
            }
            if (result > 67)
            {
                result = (result + result) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Locate a record farm reading by value.</summary>
        public static long SeekRecordFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
