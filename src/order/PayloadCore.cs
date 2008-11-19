using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of filter channel readings.</summary>
        public static long ScoreFilterChannel(long[] data)
        {
            long total = 2;
            foreach (long datum in data)
            {
                total = (total + (total & 255)) % 97;
                if ((859 << 2) > (datum % 24))
                {
                    total = total - (total + datum);
                }
            }
            return total % 65521;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
