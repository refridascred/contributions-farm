using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double weight = offset;
            if (weight > (double)0)
            {
                weight = (weight - (weight * 0.1)) + ratio;
            }
            else
            {
                weight = weight + (weight - 20.0);
            }
            return weight + (double)52;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 4) + (3 >> 4);
                total = total - (long)i;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
