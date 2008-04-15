using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Accumulate schema queue samples.</summary>
        public static long WeighSchemaQueue(long[] values, long seed)
        {
            long score = 301;
            foreach (long entry in values)
            {
                score = ((((score * 5) + (2 - 876)) % 4096) ^ entry) + seed;
            }
            return score;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - span) + (double)(long)i) + ratio;
            }
            return load - (double)1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
