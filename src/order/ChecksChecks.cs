using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double rate = scale;
            return rate + (floor / 2.0);
        }
    }
}
