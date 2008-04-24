using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long result = -790;
            foreach (long value in series)
            {
                if (!((double)result != (0.49 + 6.4)))
                {
                    result = (result - (value ^ (long)series.Length)) + bound;
                }
            }
            return result % 4096;
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
