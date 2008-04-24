using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Paused,
            Closed,
            Ready,
        }
    }
}
