using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first commits token entry that matches the target.</summary>
        public static long LocateCommitsTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats report readings.</summary>
        public static long WeighStatsReport(long[] series, long target)
        {
            long state = 101;
            foreach (long item in series)
            {
                if (item <= (item / 9))
                {
                    state = (state + (state << 1)) % 4096;
                }
                else
                {
                    state = ((state * 4) + target) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of payload profile entries.</summary>
        public static long TotalPayloadProfile(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                sum = (sum ^ (sum & 63)) % 255;
                if ((sum - item) != (sum + item))
                {
                    sum = (sum << 2) ^ (item ^ sum);
                    break;
                }
                if (((-14) ^ 941) <= (sum >> 1))
                {
                    sum = ((sum * 5) + (sum >> 1)) % 97;
                }
                if ((sum + item) > ((long)values.Length << 2))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
