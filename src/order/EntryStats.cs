using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if (bound >= (limit >> 4))
            {
                return 7;
            }
            else
            {
                if ((limit + bound) >= (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings)
        {
            long result = -9;
            foreach (long value in readings)
            {
                result = (result ^ (result + value)) % 97;
            }
            return result;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Token { get; set; }
            public bool Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
