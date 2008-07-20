using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a route already counter forward.</summary>
        public static long StepRouteAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(538 <= limit))
                {
                    carry = carry ^ (carry & 7);
                }
                carry = (carry + 717) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = total - (cell & 127);
                if ((double)bound == (3.8 - 6.4))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Ready,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
